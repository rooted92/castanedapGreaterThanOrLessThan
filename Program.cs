//Pedro Castaneda
//10-17-2022
//Greater Than or Less Than
//Create a program that will ask user to give two numbers. The program will state to them if the first or second number is greater than, less than, or equal to the other number.

bool run = true;

while(run)
{
    int num1 = 0;
    int num2 = 0;
    string userInput;
    bool checkNum1 = false;
    bool checkNum2 = false;
    bool playAgain = true;
    Console.WriteLine("Welcome to Comparison Wizard!");
    Console.WriteLine("Please enter two numbers to compare.");
    Console.WriteLine("First Number:");
    //checkNum1 = Int32.TryParse(Console.ReadLine(), out num1);
    while(!checkNum1)
    {
        checkNum1 = Int32.TryParse(Console.ReadLine(), out num1);
        if(checkNum1 == true)
        {   
            break;
        }
        else
        {
            Console.WriteLine("No funny business Jack! Enter a number!");
        }
    }
    Console.WriteLine("Second Number:");
    while(!checkNum2)
    {
        checkNum2 = Int32.TryParse(Console.ReadLine(), out num2);
        if(checkNum2 == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("No funny business Jack! Enter a number!");
        }
    }
    if(num1 > num2)
    {
        Console.WriteLine($"{num1} is greater than {num2}");
        Console.WriteLine($"{num2} is less than {num1}");
    }
    else if(num1 < num2)
    {
        Console.WriteLine($"{num1} is less than {num2}");
        Console.WriteLine($"{num2} is greater than {num1}");
    }
    else
    {
        Console.WriteLine($"{num1} is equal to {num2}");
    }

    Console.WriteLine("Would you like to play again? (yes/no)");
    while(playAgain)
    {
        userInput = Console.ReadLine().ToLower();
        if(userInput == "yes" || userInput == "y")
        {
            playAgain = false;
            run = true;
        }
        else if(userInput == "no" || userInput == "n")
        {
            playAgain = false;
            run = false;
        }
        else
        {
            Console.WriteLine("Please enter yes or no");
            playAgain = true;
        }
    }
}
