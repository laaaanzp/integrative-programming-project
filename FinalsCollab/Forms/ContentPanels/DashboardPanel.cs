using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsCollab.Forms.ContentPanels
{
    public partial class DashboardPanel : UserControl
    {
        public DashboardPanel()
        {
            InitializeComponent();

            Database.SocketConnection.OnDashboardVisitUpdate += onVisitUpdate;
            Database.SocketConnection.OnDashboardPatientsUpdate += onPatientsUpdate;
            Database.SocketConnection.OnDashboardEmployeesUpdate += onEmployeesUpdate;
        }    

        private void onVisitUpdate(JObject value)
        {
            totalVisit.ValueText = value["total"].ToString();
            currentQueueVisit.ValueText = value["current_queue"].ToString();
            todayVisit.ValueText = value["today"].ToString();
            last7DaysVisit.ValueText = value["last_7_days"].ToString();
            last30DaysVisit.ValueText = value["last_30_days"].ToString();
        }

        private void onPatientsUpdate(JObject value)
        {
            totalPatients.ValueText = value["total"].ToString();
            malePatients.ValueText = value["male"].ToString();
            femalePatients.ValueText = value["female"].ToString();
            othersPatients.ValueText = value["others"].ToString();
        }

        private void onEmployeesUpdate(JObject value)
        {
            totalEmployees.ValueText = value["total"].ToString();
            onlineEmployees.ValueText = value["online"].ToString();
            adminEmployees.ValueText = value["admin"].ToString();
            doctorEmployees.ValueText = value["doctor"].ToString();
            nurseEmployees.ValueText = value["nurse"].ToString();
            bhwEmployees.ValueText = value["bhw"].ToString();
        }
    }
}
