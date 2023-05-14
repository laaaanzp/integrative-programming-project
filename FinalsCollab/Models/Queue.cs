using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FinalsCollab.Models
{
    public class Queue
    {
        public int ID;
        public int PatientID;
        public string BloodPressure;
        public int WeightKG;
        public double HeightFT;
        public string Reason;
        public double BMI
        {
            get => Globals.FuncTools.CalculateBMI(WeightKG, HeightFT);
        }
        public string Fullname
        {
            get => PatientInformation.FromDatabase(PatientID).Fullname;
        }

        public static List<Queue> GetQueues()
        {
            return Database.DatabaseHandler.GetQueues();
        }

        public static Queue FromDatabase(int id)
        {
            return Database.DatabaseHandler.GetQueue(id);
        }

        public static Queue FromJObject(JObject value)
        {
            return new Queue()
            {
                ID = value["id"].ToObject<int>(),
                PatientID = value["patient_id"].ToObject<int>(),
                BloodPressure = value["blood_pressure"].ToString(),
                WeightKG = value["weight_kg"].ToObject<int>(),
                HeightFT = value["height_ft"].ToObject<double>(),
                Reason = value["reason"].ToString(),
            };
        }

        public void AddToDatabase()
        {
            ID = Database.DatabaseHandler.AddQueue(this);
        }

        public void DeleteFromDatabase()
        {
            Database.DatabaseHandler.DeleteRecordByID(this.ID);
        }

        public string ToStringJson()
        {
            dynamic o = new System.Dynamic.ExpandoObject();

            o.id = ID;
            o.patient_id = PatientID;
            o.blood_pressure = BloodPressure;
            o.weight_kg = WeightKG;
            o.height_ft = HeightFT;
            o.reason = Reason;

            return Database.DatabaseHandler.ObjectToJsonString(o);
        }
    }
}
