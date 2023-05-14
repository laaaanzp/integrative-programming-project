using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FinalsCollab.Models
{
    public class PatientInformation
    {
        public int ID;
        public string Fullname;
        public string Gender;
        public string Address;
        public DateTime Birthday;
        public string BloodType;
        public string MaritalStatus;
        public int NumberOfKids;
        public Contact Contact;
        public int TotalVisit
        {
            get => Database.DatabaseHandler.GetPatientTotalVisit(ID);
        }

        public static PatientInformation FromJObject(JObject value)
        {
            return new PatientInformation()
            {
                ID = value["id"].ToObject<int>(),
                Fullname = value["name"].ToString(),
                Gender = value["gender"].ToString(),
                Address = value["address"].ToString(),
                Birthday = DateTime.Parse(value["birthday"].ToString()),
                BloodType = value["bloodtype"].ToString(),
                MaritalStatus = value["marital_status"].ToString(),
                NumberOfKids = value["number_of_kids"].ToObject<int>(),
                Contact = new Contact()
                {
                    Email = value["contact"]["email"].ToString(),
                    Phone = value["contact"]["phone"].ToString()
                }
            };
        }

        public string ToStringJson()
        {
            dynamic o = new System.Dynamic.ExpandoObject();

            o.id = ID;
            o.name = Fullname;
            o.gender = Gender;
            o.address = Address;
            o.birthday = Birthday.ToString("yyyy-M-d hh:mm:ss");
            o.bloodtype = BloodType;
            o.marital_status = MaritalStatus;
            o.number_of_kids = NumberOfKids;
            o.contact = Contact;

            return Database.DatabaseHandler.ObjectToJsonString(o);
        }

        public static PatientInformation FromDatabase(int id)
        {
            return Database.DatabaseHandler.GetPatient(id);
        }

        public static List<PatientInformation> GetPatients()
        {
            return Database.DatabaseHandler.GetPatients();
        }

        public static List<PatientInformation> SearchFromDatabase(string fullname)
        {
            List<PatientInformation> searchedPatients = new List<PatientInformation>();

            return searchedPatients;
        }

        public void AddToDatabase()
        {
            ID = Database.DatabaseHandler.AddPatient(this);
        }

        public void UpdateToDatabase()
        {
            Database.DatabaseHandler.UpdatePatient(this);
        }

        public void DeleteFromDatabase()
        {
            Database.DatabaseHandler.RemovePatient(ID);
        }
    }
}
