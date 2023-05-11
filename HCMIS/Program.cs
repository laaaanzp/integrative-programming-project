using System;
using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace HCMIS
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}