using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Store_Homework_CSharp.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }

        private int _Price;

        public enum Genre
        {
            Action,
            Horror,
            Drama,
            Thriller,
            Romance,
            Sci_Fi,
            Comdey,
            Western
        }

        public void SetPrice()
        {
            // Random class for generating random vale
            Random rnd = new Random();
            if (Year < 2000)
            {
                _Price = rnd.Next(100, 201);
            }
            else if ((Year >= 2000) && (Year <= 2010))
            {
                _Price = rnd.Next(200, 301);
            }
            else
            {
                _Price = rnd.Next(300, 501);
            }
        }
    }
}

/* Create class Movie that will have the following properties: 

● Title

● Description

● Year

● Genre => enum

● Price => private property

● SetPrice => method that should set the price based on the Year property:

● If the Year is below 2000 the price should be a random number between 100-200

● If the Year is between 2000 and 2010 the price should be random number between 200-300

● If the Year is above 2010 the price should be random number between 300-500 */