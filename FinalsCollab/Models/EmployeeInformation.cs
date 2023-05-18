using FinalsCollab.Globals;
using System.Data;
using System.Data.SqlClient;

namespace FinalsCollab.Models
{
    public class EmployeeInformation
    {
        public int ID;
        public Name Name;
        public string Position;
        public Account Account;
        public Contact Contact;

        public EmployeeInformation(int id, Name name, string position, Account account, Contact contact) 
        { 
            ID = id;
            Name = name;
            Position = position;
            Account = account;
            Contact = contact;
        }

        private static EmployeeInformation Parse(SqlDataReader reader)
        {
            var id = reader.GetInt16("id");
            var firstName = reader.GetString("firstname");
            var middleName = reader.GetString("middlename");
            var lastName = reader.GetString("lastname");
            var position = reader.GetString("position");
            var email = reader.GetString("email");
            var phone = reader.GetString("phone");
            var username = reader.GetString("username");
            var password = reader.GetString("password");

            return new EmployeeInformation
            (
                id,
                new Name(firstName, middleName, lastName),
                position,
                new Account(username, password),
                new Contact(email, phone)
            );
        }

        public static List<EmployeeInformation> GetEmployees()
        {
            List<EmployeeInformation> employees = new List<EmployeeInformation>();
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetEmployees", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var employee = Parse(reader);
                        employees.Add(employee);
                    }
                }
            }

            return employees;
        }

        public static EmployeeInformation? GetEmployee(int id)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetEmployee", connection);
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

        public static EmployeeInformation? GetEmployee(Account account)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                GetEmployeesconnection.Open();

                SqlCommand command = new SqlCommand("GetEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@username", account.Username);
                command.Parameters.AddWithValue("@password", account.Password);

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

                SqlCommand command = new SqlCommand("EmployeeRegister", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@firstname", Name.Firstname);
                command.Parameters.AddWithValue("@middlename", Name.Middlename);
                command.Parameters.AddWithValue("@lastname", Name.Lastname);
                command.Parameters.AddWithValue("@position", Position);
                command.Parameters.AddWithValue("@email", Contact.Email);
                command.Parameters.AddWithValue("@phone", Contact.Phone);
                command.Parameters.AddWithValue("@username", Account.Username);
                command.Parameters.AddWithValue("@password", Account.Password);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("EmployeeDelete", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", ID);

                command.ExecuteNonQuery();
            }
        }
    }
}
