using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMIS.Models
{
    public class Record
    {
        public int ID { get; set; }
        public Patient Patient { get; set; }
        public DateTime VisitDateTime { get; set; }
        public int BloodPressure { get; set; }
        public double WeightKG { get; set; }
        public double HeightFT { get; set; }
        public string Reason { get; set; }
        public string AssignedWorker { get; set; }
        public string Remarks { get; set; }
        public bool Deferred { get; set; }

        public Record(int id, Patient patient, DateTime visitDateTime,int bloodPressure, double weightKG, double heightFT, string assignedWorker, string reason, string remarks, bool deferred)
        {
            ID = id;
            Patient = patient;
            VisitDateTime = visitDateTime;
            BloodPressure = bloodPressure;
            WeightKG = weightKG;
            HeightFT = heightFT;
            AssignedWorker = assignedWorker;
            Reason = reason;
            Remarks = remarks;
            Deferred = deferred;
        }
    }
}
