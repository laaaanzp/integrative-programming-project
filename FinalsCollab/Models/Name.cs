using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsCollab.Models
{
    public class Name
    {
        public string Firstname { get; set; } = "";
        public string Middlename { get; set; } = "";
        public string Lastname { get; set; } = "";

        [JsonIgnore]
        public string Fullname
        {
            get
            {
                if (Middlename == "")
                    return $"{Firstname} {Lastname}";

                return $"{Firstname} {Middlename} {Lastname}";
            }
        }
    }
}
