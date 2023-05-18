namespace FinalsCollab.Models
{
    public class Contact
    {
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";

        public Contact(string email, string phone)
        {
            Email = email;
            Phone = phone;
        }
    }
}
