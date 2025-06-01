using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyBites.Models
{
    public class User
    {
        public int UserID { get; set; }  // Add this line
        public string Username { get; set; }
        public string Role { get; set; }
    }
}
