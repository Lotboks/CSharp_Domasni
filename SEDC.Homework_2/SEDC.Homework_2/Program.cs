
#region Calculator
double result = 0;

Console.WriteLine("Enter first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter an operator (+, -, *, /) ");
char chooseOperation = Convert.ToChar(Console.ReadLine());

switch (chooseOperation)
{
    case '+':
        result = firstNumber + secondNumber;
        break;

    case '-':
        result = firstNumber - secondNumber;
        break;

    case '*':
        result = firstNumber * secondNumber;
        break;

    case '/':
        result = firstNumber / secondNumber;
        break;

    default:
        Console.WriteLine("Invalid Operation!");
        break;
}

Console.WriteLine("The result is: " + result);

Console.WriteLine("----------------------------------------");

#endregion

#region Average Number

Console.WriteLine("Enter first number: ");
double firstNumber01 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number: ");
double secondNumber02 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter third number: ");
double thirdNumber03 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter fourth number: ");
double fourthNumber04 = Convert.ToDouble(Console.ReadLine());

double averageNumber = (firstNumber01 + secondNumber02 + thirdNumber03 + fourthNumber04) / 4;

Console.WriteLine("The average of: " + firstNumber01 + ", " + secondNumber02 + ", " + thirdNumber03 + " and " + fourthNumber04 + " is " + averageNumber);

Console.WriteLine("----------------------------------------");

#endregion

#region Number swapper

Console.WriteLine("Input first number: ");
int firstNum01 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int secondNum02 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Number 1 before swapping: " + firstNum01);
Console.WriteLine("Number 2 before swapping: " + secondNum02);

int buffer = firstNum01;
firstNum01 = secondNum02;
secondNum02 = buffer;

Console.WriteLine();

Console.WriteLine("Number 1 after swap: " + firstNum01);
Console.WriteLine("Number 2 after swap: " + secondNum02);


#endregion