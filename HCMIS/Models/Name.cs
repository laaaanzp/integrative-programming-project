namespace HCMIS.Models
{
    public class Name
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        {
            get
            {
                if (MiddleName.Equals(""))
                {
                    return $"{FirstName} {LastName}";
                }
                
                return $"{FirstName} {MiddleName.Substring(0, 1)}. {LastName}";
            } 
        }

        public Name(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
}
