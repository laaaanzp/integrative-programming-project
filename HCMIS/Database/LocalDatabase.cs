using HCMIS.Interface;
using HCMIS.Models;
using System.Data;
using System.Data.SqlClient;
using Queue = HCMIS.Models.Queue;

namespace HCMIS.Database
{
    public class LocalDatabase : IDatabase
    {
        public static string DatabaseLocation = Application.StartupPath + "HCMISDB.mdf";
        public static string ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={DatabaseLocation};Integrated Security=True;";
        
        public void Init()
        {

        }

        public void AddQueue(Queue queue)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var patientID = queue.Patient.ID;
                var bloodPressure = queue.BloodPressure;
                var weightKG = queue.WeightKG;
                var heightFT = queue.HeightFT;
                var reason = queue.Reason;

                string query = $"INSERT INTO Queue VALUES ({patientID}, {bloodPressure}, {weightKG}, {heightFT}, '{reason}')";
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }
        }

        public void AddRecord(int queueID, Record record)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var patientID = record.Patient.ID;
                var visitDateTime = record.VisitDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                var bloodPressure = record.BloodPressure;
                var weightKG = record.WeightKG;
                var heightFT = record.HeightFT;
                var reason = record.Reason;
                var assignedWorker = record.AssignedWorker;
                var remarks = record.Remarks;
                var deferred = record.Deferred ? "Yes" : "No";

                string query = $"INSERT INTO Record VALUES ({patientID}, CAST('{visitDateTime}' AS DATETIME), {bloodPressure}, {weightKG}, {heightFT}, '{reason}', '{assignedWorker}', '{remarks}', '{deferred}');";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public List<EmployeeInformation> GetEmployees()
        {
            List<EmployeeInformation> employees = new List<EmployeeInformation>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT I.ID, I.FirstName, I.MiddleName, I.LastName, I.Position, C.Email, C.PhoneNumber, A.Username, A.Password FROM EmployeeInformation I INNER JOIN EmployeeContact C ON I.ID = C.ID INNER JOIN EmployeeAccount A ON C.ID = A.ID;";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt16("ID");
                        var firstName = reader.GetString("FirstName");
                        var middleName = reader.GetString("MiddleName");
                        var lastName = reader.GetString("LastName");
                        var position = Tools.ParsePosition(reader.GetString("Position"));
                        var email = reader.GetString("Email");
                        var phoneNumber = reader.GetString("PhoneNumber");
                        var username = reader.GetString("Username");
                        var password = reader.GetString("Password");

                        employees.Add(
                            new Employee(
                                id,
                                new Name(firstName, middleName, lastName),
                                new Account(username, password),
                                position,
                                new Contact(email, phoneNumber)
                                )
                            );
                    }
                }
            }
            return employees;
        }

        public Patient? GetPatient(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"SELECT I.ID, I.Fullname, I.Gender, I.Birthday, I.Address, I.Bloodtype, I.MaritalStatus, I.NumberOfKids, C.Email, C.PhoneNumber FROM PatientInformation I INNER JOIN PatientContact C ON I.ID = C.ID WHERE {id} = I.ID;";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    var fullname = reader.GetString("Fullname");
                    var gender = reader.GetString("Gender");
                    var birthday = reader.GetDateTime("Birthday");
                    var address = reader.GetString("Address");
                    var bloodtype = reader.GetString("Bloodtype");
                    var maritalStatus = reader.GetString("MaritalStatus");
                    var numberOfKids = reader.GetInt32("NumberOfKids");
                    var email = reader.GetString("Email");
                    var phoneNumber = reader.GetString("PhoneNumber");

                    return new Patient(
                        id,
                        fullname,
                        gender,
                        new Contact(email, phoneNumber),
                        birthday,
                        address,
                        bloodtype,
                        maritalStatus,
                        numberOfKids
                        );
                }
            }
        }

        public List<Patient> GetPatient(string fullname)
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"SELECT I.ID, I.Fullname, I.Gender, I.Birthday, I.Address, I.Bloodtype, I.MaritalStatus, I.NumberOfKids, C.Email, C.PhoneNumber FROM PatientInformation I INNER JOIN PatientContact C ON I.ID = C.ID WHERE '{fullname}' = I.Fullname;";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("ID");
                        fullname = reader.GetString("Fullname");
                        var gender = reader.GetString("Gender");
                        var birthday = reader.GetDateTime("Birthday");
                        var address = reader.GetString("Address");
                        var bloodtype = reader.GetString("Bloodtype");
                        var maritalStatus = reader.GetString("MaritalStatus");
                        var numberOfKids = reader.GetInt32("NumberOfKids");
                        var email = reader.GetString("Email");
                        var phoneNumber = reader.GetString("PhoneNumber");

                        patients.Add(
                            new Patient(
                                id,
                                fullname,
                                gender,
                                new Contact(email, phoneNumber),
                                birthday,
                                address,
                                bloodtype,
                                maritalStatus,
                                numberOfKids
                                )
                            );
                    }
                }
            }

            return patients;
        }
        

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT I.ID, I.Fullname, I.Gender, I.Birthday, I.Address, I.Bloodtype, I.MaritalStatus, I.NumberOfKids, C.Email, C.PhoneNumber FROM PatientInformation I INNER JOIN PatientContact C ON I.ID = C.ID";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("ID");
                        var fullname = reader.GetString("Fullname");
                        var gender = reader.GetString("Gender");
                        var birthday = reader.GetDateTime("Birthday");
                        var address = reader.GetString("Address");
                        var bloodtype = reader.GetString("Bloodtype");
                        var maritalStatus = reader.GetString("MaritalStatus");
                        var numberOfKids = reader.GetInt32("NumberOfKids");
                        var email = reader.GetString("Email");
                        var phoneNumber = reader.GetString("PhoneNumber");

                        patients.Add(
                            new Patient(
                                id,
                                fullname,
                                gender,
                                new Contact(email, phoneNumber),
                                birthday,
                                address,
                                bloodtype,
                                maritalStatus,
                                numberOfKids
                                )
                            );
                    }
                }
            }

            return patients;
        }

        public List<Queue> GetQueues()
        {
            List<Queue> queues = new List<Queue>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT ID, PatientID, BloodPressure, WeightKG, HeightFT, Reason FROM Queue";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("ID");
                        var patientID = reader.GetInt32("PatientID");
                        var bloodPressure = reader.GetInt32("BloodPressure");
                        var weightKG = (double)reader.GetDecimal("WeightKG");
                        var heightFT = (double)reader.GetDecimal("HeightFT");
                        var reason = reader.GetString("Reason");

                        queues.Add(
                            new Queue(
                                id,
                                GetPatient(patientID),
                                bloodPressure,
                                weightKG,
                                heightFT,
                                reason
                                )
                            );
                    }
                }
            }

            return queues;
        }

        public List<Record> GetPatientRecords(int id)
        {
            List<Record> records = new List<Record>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"SELECT ID, PatientID, VisitDateTime, BloodPressure, WeightKG, HeightFT, Reason, AssignedWorker, Remarks, Deferred FROM Record WHERE {id} = PatientID;";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var patientID = reader.GetInt32("PatientID");
                        var visitDateTime = reader.GetDateTime("VisitDateTime");
                        var bloodPressure = reader.GetInt32("BloodPressure");
                        var weightKG = (double)reader.GetDecimal("WeightKG");
                        var heightFT = (double)reader.GetDecimal("HeightFT");
                        var reason = reader.GetString("Reason");
                        var assignedWorker = reader.GetString("AssignedWorker");
                        var remarks = reader.GetString("Remarks");
                        var deferred = reader.GetString("Deferred") == "Yes";

                        records.Add(
                            new Record(
                                id,
                                GetPatient(patientID),
                                visitDateTime,
                                bloodPressure,
                                weightKG,
                                heightFT,
                                assignedWorker,
                                reason,
                                remarks,
                                deferred
                                )
                            );
                    }
                }
            }

            return records;
        }

        public List<Record> GetRecords()
        {
            List<Record> records = new List<Record>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT ID, PatientID, VisitDateTime, BloodPressure, WeightKG, HeightFT, Reason, AssignedWorker, Remarks, Deferred FROM Record;";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("ID");
                        var patientID = reader.GetInt32("PatientID");
                        var visitDateTime = reader.GetDateTime("VisitDateTime");
                        var bloodPressure = reader.GetInt32("BloodPressure");
                        var weightKG = (double)reader.GetDecimal("WeightKG");
                        var heightFT = (double)reader.GetDecimal("HeightFT");
                        var reason = reader.GetString("Reason");
                        var assignedWorker = reader.GetString("AssignedWorker");
                        var remarks = reader.GetString("Remarks");
                        var deferred = reader.GetString("Deferred") == "Yes";

                        records.Add(
                            new Record(
                                id,
                                GetPatient(patientID),
                                visitDateTime,
                                bloodPressure,
                                weightKG,
                                heightFT,
                                assignedWorker,
                                reason,
                                remarks,
                                deferred
                                )
                            );
                    }
                }
            }

            return records;
        }

        public Employee? Login(Account account)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"SELECT I.ID, I.FirstName, I.MiddleName, I.LastName, I.Position, C.Email, C.PhoneNumber, A.Username, A.Password FROM EmployeeInformation I INNER JOIN EmployeeContact C ON I.ID = C.ID INNER JOIN EmployeeAccount A ON C.ID = A.ID WHERE A.Username = '{account.Username}' AND A.Password = '{account.Password}';";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    var id = reader.GetInt16("ID");
                    var firstName = reader.GetString("FirstName");
                    var middleName = reader.GetString("MiddleName");
                    var lastName = reader.GetString("LastName");
                    var position = Tools.ParsePosition(reader.GetString("Position"));
                    var email = reader.GetString("Email");
                    var phoneNumber = reader.GetString("PhoneNumber");
                    var username = reader.GetString("Username");
                    var password = reader.GetString("Password");

                    return new Employee(
                        id,
                        new Name(firstName, middleName, lastName),
                        new Account(username, password),
                        position,
                        new Contact(email, phoneNumber)
                        );
                }
            }
        }

        public bool RegisterEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var id = employee.ID;
                var firstName = employee.Name.FirstName;
                var middleName = employee.Name.MiddleName;
                var lastName = employee.Name.LastName;
                var position = employee.Position.ToString().Replace("_", " ");
                var email = employee.Contact.Email;
                var phoneNumber = employee.Contact.PhoneNumber;
                var username = employee.Account.Username;
                var password = employee.Account.Password;

                string query = $"INSERT INTO EmployeeInformation VALUES ('{firstName}', '{middleName}', '{lastName}', '{position}'); DECLARE @ID AS SMALLINT = SCOPE_IDENTITY(); INSERT INTO EmployeeContact VALUES (@ID, '{email}', '{phoneNumber}'); INSERT INTO EmployeeAccount VALUES (@ID, '{username}', '{password}');";
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }

            return true;
        }

        public bool RegisterPatient(Patient patient)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var id = patient.ID;
                var fullname = patient.Fullname;
                var gender = patient.Gender;
                var birthday = patient.Birthday.ToString("yyyy-MM-dd HH:mm:ss.fff");
                var address = patient.Address;
                var bloodtype = patient.Bloodtype;
                var maritalStatus = patient.MaritalStatus;
                var numberOfKids = patient.NumberOfKids;
                var email = patient.Contact.Email;
                var phoneNumber = patient.Contact.PhoneNumber;

                string query = $"INSERT INTO PatientInformation VALUES ('{fullname}', '{gender}', CAST('{birthday}' AS DATETIME), '{address}', '{bloodtype}', '{maritalStatus}', {numberOfKids}); DECLARE @ID AS SMALLINT = SCOPE_IDENTITY(); INSERT INTO PatientContact VALUES (@ID, '{email}', '{phoneNumber}');";
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }

            return true;
        }

        public void RemoveEmployee(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"DELETE FROM EmployeeInformation WHERE ID = {id};";
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }
        }

        public void RemovePatient(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"DELETE FROM PatientInformation WHERE ID = {id};";
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }
        }

        public void RemoveQueue(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Queue WHERE ID = {id};";
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }
        }

        public void RemoveRecord(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Record WHERE ID = {id};";
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }
        }
    }
}
