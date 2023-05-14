using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FinalsCollab.Models
{
    public class Record
    {
        public int ID;
        public int PatientID;
        public DateTime VisitDateTime;
        public string BloodPressure;
        public int WeightKG;
        public double HeightFT;
        public string Reason;
        public int AssignedWorkerID;
        public string Remarks;
        public string Notes;
        public bool Deferred;
        public double BMI
        {
            get => Globals.FuncTools.CalculateBMI(WeightKG, HeightFT);
        }
        public string Fullname
        {
            get => PatientInformation.FromDatabase(PatientID).Fullname;
        }
        public string WorkerFullname
        {
            get => EmployeeInformation.FromDatabase(AssignedWorkerID).Name.Fullname;
        }

        public static List<Record> GetRecords()
        {
            return Database.DatabaseHandler.GetRecords();
        }

        public static Record FromDatabase(int id)
        {
            return Database.DatabaseHandler.GetRecord(id);
        }

        public static Record FromJObject(JObject value)
        {
            return new Record()
            {
                ID = value["id"].ToObject<int>(),
                PatientID = value["patient_id"].ToObject<int>(),
                VisitDateTime = DateTime.Parse(value["visit_datetime"].ToString()),
                BloodPressure = value["blood_pressure"].ToString(),
                WeightKG = value["weight_kg"].ToObject<int>(),
                HeightFT = value["height_ft"].ToObject<double>(),
                Reason = value["reason"].ToString(),
                AssignedWorkerID = value["assigned_worker_id"].ToObject<int>(),
                Remarks = value["remarks"].ToString(),
                Notes = value["notes"].ToString(),
                Deferred = value["deferred"].ToObject<bool>()
            };
        }

        public void AddToDatabase()
        {
            ID = Database.DatabaseHandler.AddRecord(this);
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
            o.visit_datetime = VisitDateTime.ToString("yyyy-M-d hh:mm:ss");
            o.blood_pressure = BloodPressure;
            o.weight_kg = WeightKG;
            o.height_ft = HeightFT;
            o.reason = Reason;
            o.assigned_worker_id = AssignedWorkerID;
            o.remarks = Remarks;
            o.notes = Notes;
            o.deferred = Deferred;

            return Database.DatabaseHandler.ObjectToJsonString(o);
        }
    }
}
