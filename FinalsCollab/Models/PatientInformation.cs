using FinalsCollab.Globals;
using System.Data;
using System.Data.SqlClient;

namespace FinalsCollab.Models
{
    public class PatientInformation
    {
        public int ID;
        public string Name;
        public string Gender;
        public string Address;
        public DateTime Birthday;
        public string Bloodtype;
        public string MaritalStatus;
        public int NumberOfKids;
        public Contact Contact;

        public int TotalVisit
        {
            get
            {
                using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetPatientTotalRecords", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@patient_id", ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return 0;

                        return reader.GetInt32("Total");
                    }
                }
            }
        }

        public PatientInformation(int id, string name, string gender, string address, DateTime birthday, string bloodtype, string maritalStatus, int numberOfKids, Contact contact)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Address = address;
            Birthday = birthday;
            Bloodtype = bloodtype;
            MaritalStatus = maritalStatus;
            NumberOfKids = numberOfKids;
            Contact = contact;
        }
        
        private static PatientInformation Parse(SqlDataReader reader)
        {
            var id = reader.GetInt16("id");
            var name = reader.GetString("name");
            var gender = reader.GetString("gender");
            var birthday = reader.GetDateTime("birthday");
            var address = reader.GetString("address");
            var bloodtype = reader.GetString("bloodtype");
            var maritalStatus = reader.GetString("marital_status");
            var numberOfKids = reader.GetInt32("number_of_kids");
            var email = reader.GetString("email");
            var phoneNumber = reader.GetString("phone");

            PatientInformation patient = new PatientInformation
            (
                id,
                name,
                gender,
                address,
                birthday,
                bloodtype,
                maritalStatus,
                numberOfKids,
                new Contact(email, phoneNumber)
            );

            return patient;
        }

        public static PatientInformation? GetPatient(int id)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetPatientByID", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    return Parse(reader);
                }
            }
        }

        public static List<PatientInformation> GetPatient(string name)
        {
            List<PatientInformation> patients = new List<PatientInformation>();

            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetPatientsByName", connection);
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.AddWithValue("@name", name);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patients.Add(Parse(reader));
                    }
                }
            }

            return patients;
        }

        public static List<PatientInformation> GetPatients()
        {
            List<PatientInformation> patients = new List<PatientInformation>();

            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetPatients", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patients.Add(Parse(reader));
                    }
                }
            }

            return patients;
        }

        public void AddToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("PatientRegister", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@gender", Gender);
                command.Parameters.AddWithValue("@birthday", Birthday);
                command.Parameters.AddWithValue("@address", Address);
                command.Parameters.AddWithValue("@bloodtype", Bloodtype);
                command.Parameters.AddWithValue("@marital_status", MaritalStatus);
                command.Parameters.AddWithValue("@number_of_kids", NumberOfKids);
                command.Parameters.AddWithValue("@email", Contact.Email);
                command.Parameters.AddWithValue("@phone", Contact.Email);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("PatientDelete", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", ID);

                command.ExecuteNonQuery();
            }
        }
    }
}
