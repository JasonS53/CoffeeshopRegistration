using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeshopRegistration.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CoffeeTemp { get; set; }
        public string CoffeeType { get; set; }
        public string TeaTemp { get; set; }
        public string TeaType { get; set; }
    }
}
