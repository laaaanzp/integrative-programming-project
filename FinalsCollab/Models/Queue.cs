using FinalsCollab.Globals;
using System.Data.SqlClient;
using System.Data;

namespace FinalsCollab.Models
{
    public class Queue
    {
        public int ID;
        public PatientInformation Patient;
        public string BloodPressure;
        public int WeightKG;
        public double HeightFT;
        public string Reason;
        public double BMI
        {
            get => Globals.FuncTools.CalculateBMI(WeightKG, HeightFT);
        }

        public Queue(int id, PatientInformation patient, string bloodPressure, int weightKG, double heightFT, string reason)
        {
            ID = id;
            Patient = patient;
            BloodPressure = bloodPressure;
            WeightKG = weightKG;
            HeightFT = heightFT;
            Reason = reason;
        }

        public static Queue Parse(SqlDataReader reader)
        {
            var id = reader.GetInt32("id");
            var patientID = reader.GetInt32("patient_id");
            var patient = PatientInformation.GetPatient(patientID);
            var bloodPressure = reader.GetString("blood_pressure");
            var weightKG = reader.GetInt32("weight_kg");
            var heightFT = reader.GetDouble("height_ft");
            var reason = reader.GetString("reason");

            return new Queue
            (
                id,
                patient,
                bloodPressure,
                weightKG,
                heightFT,
                reason
            );
        }

        public static List<Queue> GetQueues()
        {
            List<Queue> queues = new List<Queue>();
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetQueues", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        queues.Add(Parse(reader));
                    }
                }
            }

            return queues;
        }

        public static Queue? FromDatabase(int id)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetQueueByID", connection);
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

                SqlCommand command = new SqlCommand("QueueAdd", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", ID);
                command.Parameters.AddWithValue("@patient_id", Patient.ID);
                command.Parameters.AddWithValue("@blood_pressure", BloodPressure);
                command.Parameters.AddWithValue("@weight_kg", WeightKG);
                command.Parameters.AddWithValue("@height_ft", HeightFT);
                command.Parameters.AddWithValue("@reason", Reason);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("QueueDelete", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", ID);

                command.ExecuteNonQuery();
            }
        }
    }
}
