using HCMIS.Models;

namespace HCMIS
{
    public static class Globals
    {
        public static Employee? LoggedInEmployee;
        public static Form MainMenuFormRef;
        public static bool DarkModeEnabled = false;
        public static List<string> GenderSuggestions = new List<string>()
        {
            "Male", "Female", "Others"
        };
        public static List<string> ReasonSuggestions = new List<string>()
        {
            "Vaccine", "Checkup"
        };
        public static List<string> BloodTypeSuggestions = new List<string>()
        {
            "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"
        };
        public static List<string> MartialStatusSuggestions = new List<string>()
        {
            "Single", "Married", "Seperated", "Widowed"
        };
        public static string[] Months = {
            "January",   "February", "March",    "April",
            "May",       "June",     "July",     "August",
            "September", "October",  "November", "December"
        };
        public static string DatabaseConfigPath = "DatabaseConfig.json";
    }
}
