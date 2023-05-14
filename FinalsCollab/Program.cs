using FinalsCollab.Forms;
using FinalsCollab.Models;
using Newtonsoft.Json;
using System.Reflection;

namespace FinalsCollab
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, Assembly.GetEntryAssembly().GetName().Name))
            {
                if (!mutex.WaitOne(0))
                {
                    MessageBox.Show("Application is already running...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }

                ApplicationConfiguration.Initialize();

                try
                {
                    Account credentials = new Account()
                    {
                        Username = Properties.Settings.Default.Username,
                        Password = Properties.Settings.Default.Password
                    };

                    if (Properties.Settings.Default.Username != "")
                    {
                        EmployeeInformation employee = EmployeeInformation.FromLogin(credentials);
                        Globals.AppState.LoggedInEmployee = employee;
                        Application.Run(new MenuForm());
                    }
                    else
                    {
                        Application.Run(new LoginForm());
                    }
                }

                catch (CustomExceptions.InvalidCredentials)
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                    Application.Run(new LoginForm());
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}