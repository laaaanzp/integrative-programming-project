namespace FinalsCollab.Models
{
    public class Name
    {
        public string Firstname { get; set; } = "";
        public string Middlename { get; set; } = "";
        public string Lastname { get; set; } = "";

        public string Fullname
        {
            get
            {
                if (Middlename == "")
                    return $"{Firstname} {Lastname}";

                return $"{Firstname} {Middlename} {Lastname}";
            }
        }

        public Name(string firstname, string middlename, string lastname)
        {
            Firstname = firstname;
            Middlename = middlename;
            Lastname = lastname;
        }
    }
}
