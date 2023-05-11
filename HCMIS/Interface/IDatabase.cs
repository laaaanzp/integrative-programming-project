using HCMIS.Database;
using HCMIS.Models;

namespace HCMIS.Interface
{
    public interface IDatabase
    {
        public void Init();

        #region Employee
        public Employee? Login(Account accunt);
        public bool RegisterEmployee(Employee information);
        public List<Employee> GetEmployees();
        public void RemoveEmployee(int id);
        #endregion

        #region Patients
        public List<Patient> GetPatients();
        public Patient? GetPatient(int id);
        public List<Patient> GetPatient(string fullname);
        public bool RegisterPatient(Patient patient);
        public void RemovePatient(int id);
        #endregion

        #region Queue
        public void AddQueue(Queue queue);
        public List<Queue> GetQueues();
        public void RemoveQueue(int id);
        #endregion

        #region Records
        public List<Record> GetRecords();
        public List<Record> GetPatientRecords(int id);
        public void AddRecord(int queueID, Record record);
        public void RemoveRecord(int id);
        #endregion
    }
}
