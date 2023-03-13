
#region

//Console.WriteLine("Enter a string longer then 5 characters: ");
//string stringInput = Convert.ToString(Console.ReadLine());

//if (stringInput.Length >= 5)
//{
//    string lastFiveChar = stringInput.Substring(stringInput.Length - 5);
//    Console.WriteLine("Last 5 characters: " + lastFiveChar);
//} else
//{
//    Console.WriteLine("Input string is too short");
//}

#endregion

#region

//Console.Write("Enter a sentence: ");
//string sentenceInput = Console.ReadLine();

//string[] words = sentenceInput.Split(' ');

//Console.WriteLine("Words in the sentence: ");
//foreach (string word in words)
//{
//    Console.WriteLine(word);
//}

#endregion

#region

static int SumOfDigits()
{
    Console.Write("Enter a number: ");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    int sumOfDigits = 0;

    string numberString = inputNumber.ToString();

    foreach (char digit in numberString)
    {
        sumOfDigits += Convert.ToInt32(digit.ToString());
    }

    return sumOfDigits;
}

int sum = SumOfDigits();
Console.WriteLine("Sum of digits: {0}", sum);

#endregion