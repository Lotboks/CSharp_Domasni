using Movie_Store_Homework_CSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Store_Homework_CSharp.Models
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public TypeOfSubscription TypeOfSubscription { get; set; }
        public List<Movie> Movies { get; set; }

    }
}


/* 
● For the User

● MemberNumber (something like an ID)

● TypeOfSubscription (Monthly, Annually) => enum or string (it’s up to you)

● Movies => List of Movie type */