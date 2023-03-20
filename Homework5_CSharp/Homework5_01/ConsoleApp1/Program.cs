using Homework5_01.Models;

Console.WriteLine("Enter your first name:");
string firstName = Console.ReadLine();

Console.WriteLine("Enter your first name:");
string lastName = Console.ReadLine();

Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

Human human = new Human { FirstName = firstName, LastName = lastName, Age = age };

Console.WriteLine(human.GetPersonDetails());