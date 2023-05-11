namespace HCMIS.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public Name Name { get; set; }
        public Account Account { get; set; }
        public JobPosition Position { get; set; }
        public Contact Contact { get; set; }

        public Employee(int id, Name name, Account account, JobPosition position, Contact contact)
        {
            ID = id;
            Name = name;
            Account = account;
            Position = position;
            Contact = contact;
        }
    }
}
