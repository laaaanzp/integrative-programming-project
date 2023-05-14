using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FinalsCollab.Models
{
    public class EmployeeInformation
    {
        public int ID;
        public Name Name;
        public string Position;
        public Account Account;
        public Contact Contact;

        public static EmployeeInformation FromJObject(JObject o)
        {
            return new EmployeeInformation()
            { 
                ID = o["id"].ToObject<int>(),
                Name = new Name()
                {
                    Firstname = o["name"]["firstname"].ToString(),
                    Middlename = o["name"]["middlename"].ToString(),
                    Lastname = o["name"]["lastname"].ToString()
                },
                Position = o["position"].ToString(),
                Account = new Account()
                {
                    Username = o["account"]["username"].ToString(),
                    Password = o["account"]["password"].ToString()
                },
                Contact = new Contact()
                {
                    Email = o["contact"]["email"].ToString(),
                    Phone = o["contact"]["phone"].ToString()
                }
            };
        }

        public static EmployeeInformation FromDatabase(int id)
        {
            return Database.DatabaseHandler.GetEmployee(id);
        }

        public static List<EmployeeInformation> GetAllEmployees()
        {
            return Database.DatabaseHandler.GetEmployees();
        }

        public void AddToDatabase()
        {
            ID = Database.DatabaseHandler.AddEmployee(this);
        }

        public void UpdateToDatabase()
        {
            Database.DatabaseHandler.UpdateEmployee(this);
        }

        public void DeleteFromDatabase()
        {
            Database.DatabaseHandler.DeleteEmployeeByID(this.ID);
        }

        public static EmployeeInformation FromLogin(Account credentials)
        {
            return Database.DatabaseHandler.Login(credentials);
        }
    }
}
