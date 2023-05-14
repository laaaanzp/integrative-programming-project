using FinalsCollab.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Text;
using Queue = FinalsCollab.Models.Queue;

namespace FinalsCollab.Database
{
    internal class LowercaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }
    }

    internal class RequestWrapper
    {
        public HttpResponseMessage Message;
        public string JsonResult;
            
        private RequestWrapper(HttpResponseMessage message, string jsonResult)
        {
            Message = message;
            JsonResult = jsonResult;
        }

        public static RequestWrapper Get(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = client.GetAsync(url).Result;
                string result = message.Content.ReadAsStringAsync().Result;

                return new RequestWrapper(message, result);
            }
        }

        public static RequestWrapper Delete(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = client.DeleteAsync(url).Result;
                string result = message.Content.ReadAsStringAsync().Result;

                return new RequestWrapper(message, result);
            }
        }

        public static RequestWrapper Post(string url, string jsonBody)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent payload = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage message = client.PostAsync(url, payload).Result;
                string result = message.Content.ReadAsStringAsync().Result;

                return new RequestWrapper(message, result);
            }
        }

        public static RequestWrapper Post(string url, byte[] imageData)
        {
            using (HttpClient client = new HttpClient())
            {
                ByteArrayContent payload = new ByteArrayContent(imageData);
                HttpResponseMessage message = client.PostAsync(url, payload).Result;
                string result = message.Content.ReadAsStringAsync().Result;

                return new RequestWrapper(message, result);
            }
        }

        public static RequestWrapper Patch(string url, string jsonBody)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent payload = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage message = client.PatchAsync(url, payload).Result;
                string result = message.Content.ReadAsStringAsync().Result;

                return new RequestWrapper(message, result);
            }
        }

        public static RequestWrapper Patch(string url, byte[] imageData)
        {
            using (HttpClient client = new HttpClient())
            {
                ByteArrayContent payload = new ByteArrayContent(imageData);
                HttpResponseMessage message = client.PostAsync(url, payload).Result;
                string result = message.Content.ReadAsStringAsync().Result;

                return new RequestWrapper(message, result);
            }
        }
    }

    internal static class DatabaseHandler
    {

        public static string ConnectionAddress = "http://192.168.224.214:5000";

        public static string ObjectToJsonString(object o)
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new LowercaseContractResolver()
            };
            return JsonConvert.SerializeObject(o, Formatting.Indented, jsonSerializerSettings);
        }

        public static string GetEmployeeReportURL()
        {
            string url = $"{ConnectionAddress}/report";

            return url;
        }

        public static string GetProfilePictureUrlByID(int id)
        {
            return $"{ConnectionAddress}/images/{id}";
        }

        public static void AddProfilePictureByID(int id, Image image)
        {
            string url = GetProfilePictureUrlByID(id);

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                RequestWrapper.Post(url, ms.ToArray());
            }
        }

        public static void DeleteProfilePictureByID(int id)
        {
            string url = GetProfilePictureUrlByID(id);

            RequestWrapper.Delete(url);
        }

        public static EmployeeInformation Login(Account credentials)
        {
            string username = credentials.Username;
            string password = credentials.Password;
            string url = $"{ConnectionAddress}/login?username={username}&password={password}";
                
            RequestWrapper request = RequestWrapper.Get(url);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);
            
            if (!result.IsSuccessStatusCode)
                throw new CustomExceptions.InvalidCredentials(jsonObject["message"].ToString());

            return EmployeeInformation.FromJObject(jsonObject); 
        }

        public static void Logout()
        {
            string url = $"{ConnectionAddress}/logout";
            // RequestWrapper.Get(url);
        }
        

        // Employees
        public static void UpdateImageOfEmployeeByID(int id, Image image)
        {

        }

        public static List<EmployeeInformation> GetEmployees()
        {
            string url = $"{ConnectionAddress}/employees";
            List<EmployeeInformation> employees = new List<EmployeeInformation>();

            RequestWrapper request = RequestWrapper.Get(url);
            HttpResponseMessage result = request.Message;
            JArray jsonObjectArray = JArray.Parse(request.JsonResult);

            if (!result.IsSuccessStatusCode)
                return employees;

            foreach(JObject jsonObject in jsonObjectArray)
            {
                employees.Add(EmployeeInformation.FromJObject(jsonObject));
            }

            return employees;
        }

        public static EmployeeInformation GetEmployee(int id)
        {
            string url = $"{ConnectionAddress}/employee?id={id}";

            RequestWrapper request = RequestWrapper.Get(url);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);

            return EmployeeInformation.FromJObject(jsonObject);
        }

        public static int AddEmployee(EmployeeInformation employee)
        {
            string url = $"{ConnectionAddress}/employee";

            string jsonBody = ObjectToJsonString(employee);

            RequestWrapper request = RequestWrapper.Post(url, jsonBody);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);

            if (!result.IsSuccessStatusCode)
                throw new CustomExceptions.UsernameAlreadyExists(jsonObject["message"].ToString());

            return jsonObject["id"].ToObject<int>();
        }

        public static void UpdateEmployee(EmployeeInformation employee)
        {
            string url = $"{ConnectionAddress}/employee";

            string jsonBody = ObjectToJsonString(employee);

            RequestWrapper request = RequestWrapper.Patch(url, jsonBody);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);

            if (!result.IsSuccessStatusCode)
                throw new CustomExceptions.UsernameAlreadyExists(jsonObject["message"].ToString());
        }

        public static void DeleteEmployeeByID(int id)
        {
            string url = $"{ConnectionAddress}/employee?id={id}";

            RequestWrapper request = RequestWrapper.Delete(url);
            JObject jsonObject = JObject.Parse(request.JsonResult);
        }
        

        // Patients
        public static int GetPatientTotalVisit(int id)
        {
            string url = $"{ConnectionAddress}/patient/total_visit?id={id}";

            RequestWrapper request = RequestWrapper.Get(url);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);

            return jsonObject["value"].ToObject<int>();
        }

        public static List<PatientInformation> GetPatients()
        {
            string url = $"{ConnectionAddress}/patients";
            List<PatientInformation> patients = new List<PatientInformation>();

            RequestWrapper request = RequestWrapper.Get(url);
            HttpResponseMessage result = request.Message;
            JArray jsonObjectArray = JArray.Parse(request.JsonResult);

            if (!result.IsSuccessStatusCode)
                return patients;

            foreach (JObject jsonObject in jsonObjectArray)
            {
                patients.Add(PatientInformation.FromJObject(jsonObject));
            }

            return patients;
        }

        public static PatientInformation GetPatient(int id)
        {
            string url = $"{ConnectionAddress}/patient?id={id}";

            RequestWrapper request = RequestWrapper.Get(url);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);

            if (!result.IsSuccessStatusCode)
                throw new CustomExceptions.DataNotFound(jsonObject["message"].ToString());

            return PatientInformation.FromJObject(jsonObject);
        }

        public static int AddPatient(PatientInformation patient)
        {
            string url = $"{ConnectionAddress}/patient";
            string jsonBody = patient.ToStringJson();

            RequestWrapper request = RequestWrapper.Post(url, jsonBody);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);

            return jsonObject["id"].ToObject<int>();
        }

        public static void RemovePatient(int id)
        {
            string url = $"{ConnectionAddress}/patient?id={id}";
            RequestWrapper request = RequestWrapper.Delete(url);        
        }

        public static void UpdatePatient(PatientInformation patient)
        {
            string url = $"{ConnectionAddress}/patient";
            string jsonBody = patient.ToStringJson();

            RequestWrapper request = RequestWrapper.Patch(url, jsonBody);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);
        }

        public static List<Queue> GetQueues()
        {
            string url = $"{ConnectionAddress}/queues";

            List<Queue> queues = new List<Queue>();

            RequestWrapper request = RequestWrapper.Get(url);
            HttpResponseMessage result = request.Message;
            JArray jsonObjectArray = JArray.Parse(request.JsonResult);

            if (!result.IsSuccessStatusCode)
                return queues;

            foreach (JObject jsonObject in jsonObjectArray)
            {
                queues.Add(Queue.FromJObject(jsonObject));
            }

            return queues;
        }

        public static Queue GetQueue(int id)
        {
            string url = $"{ConnectionAddress}/queue?id={id}";

            RequestWrapper request = RequestWrapper.Get(url);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);

            return Queue.FromJObject(jsonObject);
        }

        public static int AddQueue(Queue queue)
        {
            string url = $"{ConnectionAddress}/queue";

            RequestWrapper request = RequestWrapper.Post(url, queue.ToStringJson());
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);

            return jsonObject["id"].ToObject<int>();
        }

        public static void DeleteRecordByID(int id)
        {
            string url = $"{ConnectionAddress}/queue?id={id}";

            RequestWrapper request = RequestWrapper.Delete(url);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);
        }

        public static List<Record> GetRecords()
        {
            string url = $"{ConnectionAddress}/records";

            List<Record> records = new List<Record>();

            RequestWrapper request = RequestWrapper.Get(url);
            HttpResponseMessage result = request.Message;
            JArray jsonObjectArray = JArray.Parse(request.JsonResult);

            if (!result.IsSuccessStatusCode)
                return records;

            foreach (JObject jsonObject in jsonObjectArray)
            {
                records.Add(Record.FromJObject(jsonObject));
            }

            return records;
        }

        public static Record GetRecord(int id)
        {
            string url = $"{ConnectionAddress}/record?id={id}";

            RequestWrapper request = RequestWrapper.Get(url);
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);

            return Record.FromJObject(jsonObject);
        }

        public static int AddRecord(Record record)
        {
            string url = $"{ConnectionAddress}/record";

            RequestWrapper request = RequestWrapper.Post(url, record.ToStringJson());
            HttpResponseMessage result = request.Message;
            JObject jsonObject = JObject.Parse(request.JsonResult);

            return jsonObject["id"].ToObject<int>();
        }
    }
}
