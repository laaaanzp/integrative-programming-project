using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMIS.Models
{
    public class Queue
    {
        public int ID { get; set; } 
        public Patient Patient { get; set; }
        public int BloodPressure { get; set; }
        public double WeightKG { get; set; }
        public double HeightFT { get; set; }
        public string Reason { get; set; }

        public Queue(int id, Patient patient, int bloodPressure, double weightKG, double heightFT, string reason)
        {
            ID = id;
            Patient = patient;
            BloodPressure = bloodPressure;
            WeightKG = weightKG;
            HeightFT = heightFT;
            Reason = reason;
        }
    }
}
