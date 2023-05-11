# Modules
from flask import Flask, request, jsonify
import pyodbc as odbc

# Built-in Modules
from datetime import datetime
import os

# Custom Modules
from models import Employee, Name, Contact, Account, Position


DRIVER = "SQL SERVER"
SERVER = "LENOVOEMS"
DATABASE = "HCMISDB"


connection_string = (
    f"DRIVER={{{DRIVER}}};"
    f"SERVER={SERVER};"
    f"DATABASE={DATABASE};"
    "Trust_Connection=yes;"
)


connection = None


def execute_command(command: str) -> odbc.Cursor:
    cursor = connection.cursor()
    cursor.execute(command)

    return cursor


def create_connection():
    global connection_string, connection

    try:
        connection = odbc.connect(connection_string, autocommit=True)
    except odbc.ProgrammingError as E:
        connection_string = connection_string.replace(DATABASE, "master")
        connection = odbc.connect(connection_string, autocommit=True)
    
        execute_command(f"CREATE DATABASE {DATABASE}")
        execute_command(f"USE {DATABASE}")
        create_tables()


def create_tables() -> None:
    tables = [
        "./database_tables/employee.txt",
        "./database_tables/patient.txt",
        "./database_tables/queue.txt",
        "./database_tables/record.txt"
        ]

    for table in tables:
        with open (table, "r") as r:
            print(table)
            queries = r.read().split("\n")
            for query in queries:
                execute_command(query)


def format_select_result(cursor: odbc.Cursor) -> list[dict[str, object]]:
    results = []
    columns = [column[0] for column in cursor.description]

    for row in cursor.fetchall():
        results.append(dict(zip(columns, row)))

    return results


create_connection()


# SERVER
server = Flask(__name__)


@server.get("/login")
def login():
    username = request.args.get("username", "")
    password = request.args.get("password", "")

    with open("./queries/employee/login.txt", "r") as r:
        query = r.read().replace("@USERNAME", username) \
                        .replace("@PASSWORD", password)

    cursor = execute_command(query)
    result = cursor.fetchone()
    if (result):
        print(result)
        return jsonify(result=[str(i) for i in result]), 200
    else:
        return jsonify(result=[]), 401


@server.post("/register_employee")
def register_employee():
    data = request.get_json()

    first_name = data.get("FirstName")
    middle_name = data.get("MiddleName")
    last_name = data.get("LastName")
    username = data.get("Username")
    password = data.get("Password")
    email = data.get("Email")
    phone_number = data.get("PhoneNumber")
    position = data.get("Position")


    if "" in [first_name, last_name, username, password, position]:
        return jsonify(result=[]), 400

    with open("./queries/employee/register.txt", "r") as r:
        query = r.read().replace("@FIRSTNAME", first_name) \
                        .replace("@MIDDLENAME", middle_name) \
                        .replace("@LASTNAME", last_name) \
                        .replace("@POSITION", position) \
                        .replace("@EMAIL", email) \
                        .replace("@PHONE_NUMBER", phone_number) \
                        .replace("@USERNAME", username) \
                        .replace("@PASSWORD", password)
    
    execute_command(query)

    return jsonify(result=[]), 200


@server.get("/get_employees")
def get_employees():
    with open("./queries/employee/get_employees.txt", "r") as r:
        query = r.read()

    cursor = execute_command(query)
    results = cursor.fetchall()

    data = []
    for result in results:
        data.append([str(i) for i in result])

    return jsonify(result=data), 200


@server.delete("/remove_employee")
def remove_employee():
    id = int(request.args.get("id", 0))

    with open ("./queries/employee/remove.txt", "r") as r:
        query = r.read().replace("@ID", str(id))

    execute_command(query)

    return jsonify(result=[]), 200


@server.post("/register_patient")
def register_patient():
    data = request.get_json()

    fullname = data.get("Fullname", "")
    gender = data.get("Gender", "")
    birthday = data.get("Birthday", "")
    address = data.get("Address", "")
    bloodtype = data.get("Bloodtype", "")
    martial_status = data.get("MartialStatus", "")
    email = data.get("Email", "")
    phone_number = data.get("PhoneNumber", "")
    number_of_kids = str(data.get("NumberOfKids", 0))
    print(martial_status)

    if "" in [fullname, gender, birthday, address, bloodtype, martial_status]:
        return jsonify(result=[]), 400

    with open("./queries/patient/register.txt", "r") as r:
        query = r.read().replace("@FULLNAME", fullname) \
                        .replace("@GENDER", gender) \
                        .replace("@BIRTHDAY", birthday) \
                        .replace("@ADDRESS", address) \
                        .replace("@BLOODTYPE", bloodtype) \
                        .replace("@MARTIAL_STATUS", martial_status) \
                        .replace("@EMAIL", email) \
                        .replace("@PHONE_NUMBER", phone_number) \
                        .replace("@NUMBER_OF_KIDS", number_of_kids)
    
    execute_command(query)
    
    return jsonify(result=[]), 200


@server.delete("/remove_patient")
def remove_patient():
    id = int(request.args.get("id", 0))

    with open ("./queries/patient/remove.txt", "r") as r:
        query = r.read().replace("@ID", str(id))

    execute_command(query)

    return jsonify(result=[]), 200


@server.get("/get_patients")
def get_patients():
    with open("./queries/patient/get_patients.txt", "r") as r:
        query = r.read()

    cursor = execute_command(query)
    results = cursor.fetchall()

    data = []
    for result in results:
        data.append([str(i) for i in result])

    return jsonify(result=data), 200


@server.get("/get_patient_by_fullname")
def get_patient_by_fullname():
    fullname = request.args.get("fullname", "")

    with open("./queries/patient/get_patient_by_fullname.txt", "r") as r:
        query = r.read().replace("@FULLNAME", fullname)

    cursor = execute_command(query)

    results = cursor.fetchall()

    data = []
    for result in results:
        data.append([str(i) for i in result])

    return jsonify(result=data), 200


@server.get("/get_patient_by_id")
def get_patient_by_id():
    id = request.args.get("id", "")

    with open("./queries/patient/get_patient_by_id.txt", "r") as r:
        query = r.read().replace("@ID", id)

    cursor = execute_command(query)

    result = cursor.fetchone()

    if (result):
        return jsonify(result=[str(i) for i in result]), 200
    else:
        return jsonify(result=[]), 401

    
@server.post("/add_queue")
def add_queue():
    data = request.get_json()

    patient_id = data.get("PatientID")
    blood_pressure = data.get("BloodPressure")
    weight_kg = data.get("WeightKG")
    height_ft = data.get("HeightFT")
    reason = data.get("Reason")

    with open("./queries/queue/add_queue.txt", "r") as r:
        query = r.read().replace("@PATIENT_ID", patient_id) \
                        .replace("@BLOOD_PRESSURE", blood_pressure) \
                        .replace("@WEIGHT_KG", weight_kg) \
                        .replace("@HEIGHT_FT", height_ft) \
                        .replace("@REASON", reason)

    execute_command(query)

    return jsonify(result=[]), 200


@server.get("/get_queue_by_id")
def get_queue_by_id():
    id = request.args.get("id")
    
    with open("./queries/queue/get_queue_by_id.txt", "r") as r:
        query = r.read().replace("@ID", id)

    cursor = execute_command(query)
    result = cursor.fetchone()

    return jsonify(result=[str(i) for i in result]), 200


@server.get("/get_queues")
def get_queues():
    with open("./queries/queue/get_queues.txt", "r") as r:
        query = r.read()
    
    cursor = execute_command(query)
    results = cursor.fetchall()

    data = []
    for result in results:
        data.append([str(i) for i in result])

    return jsonify(result=data), 200


@server.delete("/remove_queue")
def remove_queue():

    id = request.args.get("id")
    with open("./queries/queue/remove_queue.txt", "r") as r:
        query = r.read().replace("@ID", id)
    
    execute_command(query)

    return jsonify(result=[]), 200


@server.get("/get_patient_records")
def get_patient_records():
    id = request.args.get("id")
    
    with open("./queries/record/get_patient_records.txt", "r") as r:
        query = r.read().replace("@PatientID", id)
    
    cursor = execute_command(query)
    results = cursor.fetchall()

    data = []
    for result in results:
        data.append([str(i) for i in result])

    return jsonify(result=data), 200


@server.get("/get_records")
def get_records():
    with open("./queries/record/get_records.txt", "r") as r:
        query = r.read()
    
    cursor = execute_command(query)
    results = cursor.fetchall()

    data = []
    for result in results:
        data.append([str(i) for i in result])

    return jsonify(result=data), 200


@server.post("/add_record")
def add_record():
    data = request.get_json()

    queue_id = data.get("QueueID")
    visit_date_time = data.get("VisitDateTime")
    assigned_worker = data.get("AssignedWorker")
    remarks = data.get("Remarks")
    deferred = data.get("Deferred")

    with open("./queries/queue/get_queue_by_id.txt", "r") as r:
        query = r.read().replace("@ID", queue_id)
    
    cursor = execute_command(query)
    result = [i for i in cursor.fetchone()]

    patient_id = result[1]
    blood_pressure = result[2]
    weight_kg = result[3]
    height_ft = result[4]
    reason = result[5]

    with open("./queries/record/add_record.txt", "r") as r:
        query = r.read().replace("@PATIENT_ID", str(patient_id)) \
                        .replace("@BLOOD_PRESSURE", str(blood_pressure)) \
                        .replace("@WEIGHT_KG", str(weight_kg)) \
                        .replace("@HEIGHT_FT", str(height_ft)) \
                        .replace("@REASON", reason) \
                        .replace("@VISIT_DATE_TIME", visit_date_time) \
                        .replace("@ASSIGNED_WORKER", assigned_worker) \
                        .replace("@REMARKS", remarks) \
                        .replace("@DEFERRED", deferred)
    
    execute_command(query)

    return jsonify(result=[]), 200



server.run(host="0.0.0.0", port=5000, debug=True)
