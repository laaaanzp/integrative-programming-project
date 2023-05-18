using FinalsCollab.Globals;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace FinalsCollab.Models
{
    public class Record
    {
        public int ID;
        public PatientInformation Patient;
        public DateTime VisitDateTime;
        public string BloodPressure;
        public int WeightKG;
        public double HeightFT;
        public string Reason;
        public EmployeeInformation AssignedWorker;
        public string Remarks;
        public string Notes;
        public bool Deferred;

        public double BMI
        {
            get => Globals.FuncTools.CalculateBMI(WeightKG, HeightFT);
        }

        public Record(int id, PatientInformation patient, DateTime visitDateTime, string bloodPressure, int weightKG, double heightFT, string reason, EmployeeInformation assignedWorker, string remarks, string notes, bool deferred)
        {
            ID = id;
            Patient = patient;
            VisitDateTime = visitDateTime;
            BloodPressure = bloodPressure;
            WeightKG = weightKG;
            HeightFT = heightFT;
            Reason = reason;
            AssignedWorker = assignedWorker;
            Remarks = remarks;
            Notes = notes;
            Deferred = deferred;
        }

        public static Record Parse(SqlDataReader reader)
        {
            var id = reader.GetInt32("id");
            var patient_id = reader.GetInt32("patient_id");
            var patient = PatientInformation.GetPatient(patient_id);
            var visitDateTime = reader.GetDateTime("visit_datetime");
            var bloodPressure = reader.GetString("blood_pressure");
            var weightKG = reader.GetInt32("weight_kg");
            var heightFT = reader.GetDouble("height_ft");
            var reason = reader.GetString("reason");
            var assignedWorkerID = reader.GetInt16("@assigned_worker_id");
            var assignedWorker = EmployeeInformation.GetEmployee(assignedWorkerID);
            var remarks = reader.GetString("remarks");
            var notes = reader.GetString("notes");
            var deferred = (bool)reader["deferred"];

            return new Record
            (
                id,
                patient,
                visitDateTime,
                bloodPressure,
                weightKG,
                heightFT,
                reason,
                assignedWorker,
                remarks,
                notes,
                deferred
            );
        }

        public static List<Record> GetRecords()
        {

            List<Record> records = new List<Record>();
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetRecords", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        records.Add(Parse(reader));
                    }
                }
            }

            return records;
        }

        public static Record? FromDatabase(int id)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetRecordByID", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    return Parse(reader);
                }
            }
        }

        public void AddToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("RecordAdd", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@patient_id", Patient.ID);
                command.Parameters.AddWithValue("@visit_datetime", VisitDateTime);
                command.Parameters.AddWithValue("@blood_pressure", BloodPressure);
                command.Parameters.AddWithValue("@weight_kg", WeightKG);
                command.Parameters.AddWithValue("@height_ft", HeightFT);
                command.Parameters.AddWithValue("@reason", Reason);
                command.Parameters.AddWithValue("@assigned_worker_id", AssignedWorker.ID);
                command.Parameters.AddWithValue("@remarks", Remarks);
                command.Parameters.AddWithValue("@notes", Notes);
                command.Parameters.AddWithValue("@deferred", Convert.ToInt16(Deferred));

                command.ExecuteNonQuery();
            }
        }

        public void DeleteFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("RecordDelete", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", ID);

                command.ExecuteNonQuery();
            }
        }
    }
}