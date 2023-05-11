using HCMIS.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMIS.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public Contact Contact { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Bloodtype { get; set; }
        public string MaritalStatus { get; set; }
        public int NumberOfKids { get; set; }
        public int TotalVisit
        {
            get => GetRecords().Count;
        }

        public Patient(int id, string fullname, string gender, Contact contact, DateTime birthday, string address, string bloodtype, string maritalStatus, int numberOfKids)
        {
            ID = id;
            Fullname = fullname;
            Gender = gender;
            Contact = contact;
            Birthday = birthday;
            Address = address;
            Bloodtype = bloodtype;
            MaritalStatus = maritalStatus;
            NumberOfKids = numberOfKids;
        }

        public List<Record> GetRecords()
        {
            return DatabaseHandler.DB.GetPatientRecords(ID);
        }
    }
}
