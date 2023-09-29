decimal balance = 1000; // initialize account balance to $1000
bool quit = false;
int currentOption = 1;

while (!quit)
{
    Console.Clear();
    Console.WriteLine("Welcome to the ATM. Please select an option:");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"   {(currentOption == 1 ? ">" : " ")} 1. Check balance");
    Console.WriteLine($"   {(currentOption == 2 ? ">" : " ")} 2. Withdraw money");
    Console.WriteLine($"   {(currentOption == 3 ? ">" : " ")} 3. Deposit money");
    Console.ForegroundColor = ConsoleColor.White;

    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    switch (keyInfo.Key)
    {
        case ConsoleKey.UpArrow:
            if (currentOption > 1)
            {
                currentOption--;
            }
            break;
        case ConsoleKey.DownArrow:
            if (currentOption < 3)
            {
                currentOption++;
            }
            break;
        case ConsoleKey.Enter:
            switch (currentOption)
            {
                case 1:
                    Console.Write($"You have ${balance} on your account.");
                    break;
                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                    {
                        if (amount > balance)
                        {
                            Console.Write($"You cannot withdraw ${amount} because your balance is ${balance}. Please try again with appropriate amount!");
                        }
                        else
                        {
                            balance -= amount;
                            Console.Write($"You have successfully withdrawn ${amount} and you have ${balance} left on your account.");
                        }
                    }
                    else
                    {
                        Console.Write("Invalid input. Please enter a valid amount.");
                    }
                    break;
                case 3:
                    Console.Write("Enter amount to deposit: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        balance += depositAmount;
                        Console.Write($"You have successfully deposited ${depositAmount} and you have ${balance} on your account.");
                    }
                    else
                    {
                        Console.Write("Invalid input. Please enter a valid amount.");
                    }
                    break;
            }
            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
            break;
        case ConsoleKey.Escape:
            quit = true;
            break;
    }
}