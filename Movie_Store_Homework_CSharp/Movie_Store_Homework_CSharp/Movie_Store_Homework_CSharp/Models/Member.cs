using Movie_Store_Homework_CSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Store_Homework_CSharp.Models
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role Role { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"* #{FirstName} #{LastName} | Registered on: {DateOfRegistration}");
        }
    }
}




/* Create a Member class that will hold all the following properties, which are common for every user:

● FirstName

● LastName

● Age

● UserName

● Password

● PhoneNumber

● DateOfRegistration

● Role => enum or string (it’s up to you)

● DisplayInfo => Method that will display info about every user,
in format: * #firstName #lastName | Registered on: #dateOfRegistration */