namespace Homework4_Task4
{
        public class Program
        {
            public static void Main()
            {
                Console.Write("Enter your birthday (MM/DD/YYYY): ");
                DateTime birthday = DateTime.Parse(Console.ReadLine());

                int age = AgeCalculator(birthday);
                Console.WriteLine("Your age is " + age);
            }

            public static int AgeCalculator(DateTime birthday)
            {
                DateTime today = DateTime.Today;
                int age = today.Year - birthday.Year;

                if (birthday > today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }
    }