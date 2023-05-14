using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsCollab.Database
{
    internal static class SocketConnection
    {
        // Dashboard
        public static event Action<JObject> OnDashboardVisitUpdate = delegate { };
        public static event Action<JObject> OnDashboardPatientsUpdate = delegate { };
        public static event Action<JObject> OnDashboardEmployeesUpdate = delegate { };

        // Patient List
        public static event Action<JObject> OnPatientListAdd = delegate { };
        public static event Action<JObject> OnPatientListRemove = delegate { };
        public static event Action<JObject> OnPatientListUpdate = delegate { };

        // Queue List
        public static event Action<JObject> OnQueueListAdd = delegate { };
        public static event Action<JObject> OnQueueListRemove = delegate { };

        // Record List
        public static event Action<JObject> OnRecordListAdd = delegate { };
        public static event Action<JObject> OnRecordListRemove = delegate { };

        // Employee List
        public static event Action<JObject> OnEmployeeListAdd = delegate { };
        public static event Action<JObject> OnEmployeeListRemove = delegate { };
        public static event Action<JObject> OnEmployeeListUpdate = delegate { };

        private static string _address = "192.168.224.214";
        private static int _port = 5001;
        private static SimpleTcpClient _client = new();

        public static void Connect()
        {
            _client.StringEncoder = Encoding.UTF8;
            _client.DataReceived += OnDataReceived;
            _client.Connect(_address, _port);
        }

        public static void Disconnect()
        {
            _client.Disconnect();
        }

        private static void OnDataReceived(object? sender, SimpleTCP.Message e)
        {
            string raw_data = e.MessageString;
            string[] raw_data_splitted = raw_data.Split("\n\n\n");

            foreach (string data in raw_data_splitted)
            {
                if (data == "")
                    continue;

                JObject jsonObject = JObject.Parse(data);
                string event_type = jsonObject["event_type"].ToString();
                JObject value = JObject.Parse(jsonObject["value"].ToString());

                Action<JObject> action = delegate { };
                switch (event_type)
                {
                    // Dashboard
                    case "dashboard_visit_update":
                        action = OnDashboardVisitUpdate;
                        break;
                    case "dashboard_patients_update":
                        action = OnDashboardPatientsUpdate;
                        break;
                    case "dashboard_employees_update":
                        action = OnDashboardEmployeesUpdate;
                        break;

                    // Patient List
                    case "patient_list_add":
                        action = OnPatientListAdd;
                        break;
                    case "patient_list_remove":
                        action = OnPatientListRemove;
                        break;
                    case "patient_list_update":
                        action = OnPatientListUpdate;
                        break;

                    // Queue List
                    case "queue_list_add":
                        action = OnQueueListAdd;
                        break;
                    case "queue_list_remove":
                        action = OnQueueListRemove;
                        break;

                    // Record List
                    case "record_list_add":
                        action = OnRecordListAdd;
                        break;
                    case "record_list_remove":
                        action = OnRecordListRemove;
                        break;

                    // Employee List
                    case "employee_list_add":
                        action = OnEmployeeListAdd;
                        break;
                    case "employee_list_remove":
                        action = OnEmployeeListRemove;
                        break;
                    case "employee_list_update":
                        action = OnEmployeeListUpdate;
                        break;

                    default:
                        break;
                }

                // Wait for Globals.AppState.MenuFormInstance to be referenced to the main form
                do { }
                while (Globals.AppState.MenuFormInstance == null);

                Globals.AppState.MenuFormInstance.Invoke(new MethodInvoker(() => action(value)));
            }
        }
    }
}
