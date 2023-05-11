namespace HCMIS.Models
{
    public class Contact
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
