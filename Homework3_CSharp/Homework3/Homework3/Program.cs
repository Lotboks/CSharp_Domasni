#region

//int[] numbersArray = new int[6];
//Console.WriteLine("Enter 6 numbers:");

//for (int i = 0; i < numbersArray.Length; i++)
//{
//    while (true)
//    {
//        if (int.TryParse(Console.ReadLine(), out int input)) // Eve i so TryParse da ne bide samo so convert.to :)
//        {
//            numbersArray[i] = input;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter a number.");
//        }
//    }
//}
//int evenSum = 0;

//for (int i = 0; i < numbersArray.Length; i++)
//{
//    if (numbersArray[i] % 2 == 0)
//    {
//        evenSum += numbersArray[i];
//    }
//}

//Console.WriteLine($"The sum of the even numbers is: {evenSum}");

#endregion

#region

string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Mile", "Cacko", "Toso", "Dzoni", "Blazo" };

Console.Write("Enter student group: (there are 1 and 2): ");

int groupNumber;
if (int.TryParse(Console.ReadLine(), out groupNumber))
{
    if (groupNumber == 1)
    {
        Console.WriteLine("The Students in G1 are:");

        foreach (string students in studentsG1)
        {
            Console.WriteLine(students);
        }
    }

    else if (groupNumber == 2)
    {
        Console.WriteLine("The Students in G2 are:");

        foreach (string students in studentsG2)
        {
            Console.WriteLine(students);
        }
    }

    else
    {
        Console.WriteLine("Invalid group number. Please enter 1 or 2.");
    }
}

else
{
    Console.WriteLine("Invalid input. Please enter a number between 1 and 2.");
}

#endregion