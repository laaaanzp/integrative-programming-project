using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsCollab.Models
{
    public class Contact
    {
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";

        public static Contact FromJObject(JObject value)
        {
            return new Contact()
            {
                Email = value["email"].ToString(),
                Phone = value["phone"].ToString()
            };
        }

        public string ToStringJson()
        {
            return Database.DatabaseHandler.ObjectToJsonString(this);
        }
    }
}
