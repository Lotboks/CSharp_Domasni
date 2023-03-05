
#region Apples and baskets

Console.WriteLine("Hello, World!");

Console.WriteLine("How many trees would you like: ");
int trees = Convert.ToInt32(Console.ReadLine());

int apples = 8;
int basketSize = 5;
int appleTotal = trees * 12 * apples;

//Thread.Sleep(1000);
Console.WriteLine("Total apples: " + appleTotal);
int totalBaskets = appleTotal / basketSize;
//Console.WriteLine("Calculating total baskets...");

//Thread.Sleep(2000);
Console.WriteLine("It will take you: " + totalBaskets + " baskets to fill your desired amount of apples.");

Console.WriteLine("---------------------------------------------");

#endregion

#region Larger/Even-Odd
Console.WriteLine("Write first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("The first number is larger then the second. " + num1);

    if (num1 % 2 == 0)
    {
        Console.WriteLine("The number is Even");
    }
    else
    {
        Console.WriteLine("The number is odd");
    }

}
else
{
    Console.WriteLine("The second number is larger then the first. " + num2);

    if (num2 % 2 == 0)
    {
        Console.WriteLine("The number is Even");
    }
    else
    {
        Console.WriteLine("The number is odd");
    }
}

Console.WriteLine("---------------------------------------------");

#endregion

#region

Console.WriteLine("Enter a number from 1-3 to win a prize!! ");
int prizeNumber = Convert.ToInt32(Console.ReadLine());

switch (prizeNumber)
{
    case 1:
        Console.WriteLine("Congratulations you just won a car!!! ");
        break;
    case 2:
        Console.WriteLine("Congratulations you just won a private jet!!! ");
        break;
    case 3:
        Console.WriteLine("Congratulations you just won a new BMX Bike!!! ");
        break;
    default:
        Console.WriteLine("You entered a wrong number you win nothing.");
        break;
}
#endregion