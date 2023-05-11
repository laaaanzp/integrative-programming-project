using HCMIS.Interface;

namespace HCMIS.Database
{
    public static class DatabaseHandler
    {
        public static IDatabase DB;
        
        public static void Initialize()
        {
            DB = new LocalDatabase();
            DB.Init();
        }
    }
}
