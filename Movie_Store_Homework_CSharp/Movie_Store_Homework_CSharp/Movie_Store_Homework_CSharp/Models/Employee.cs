using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Store_Homework_CSharp.Models
{
    public class Employee : Member
    {
        private int _Salary = 300;
        public int HoursPerMonth { get; set; }
        public int? Bonus { get; set; }
        // int? helps in handling null values

        public void SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                Bonus = Convert.ToInt32(HoursPerMonth * 0.3);
            }
            else
            {
                Bonus = null;
            }
        }
        public void SetSalary()
        {
            if (Bonus == null)
            {
                _Salary = 0;
            }
            else
            {
                _Salary = Convert.ToInt32(HoursPerMonth * Bonus);
            }
        }
    }
}

/* Create the classes Employee and User,
 which will inherit from the Member class and will have its own properties and methods.
● For the Employee

● Salary => not accessible property from outside,
which should have default value when instantiating an object from Employee class of 300 eur

● HoursPerMonth

● Bonus

● SetBonus => method that will dynamically set Bonus to the Employee by checking:

if the employee has HoursPerMonth > 160 hours it should be 30% (0.3)

If the employee has HoursPerMonth < 160 then it should be set to null (check nullable integer)

● SetSalary => method that should set the value to the Salary property,
by doing the multiplication of HoursPerMonth * Bonus

● For the User

● MemberNumber (something like an ID)

● TypeOfSubscription (Monthly, Annually) => enum or string (it’s up to you)

● Movies => List of Movie type */