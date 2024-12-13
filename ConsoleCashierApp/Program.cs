using ConsoleCashierApp.Controllers;

class Program
{
    private static bool isProgramRunning = true;
    private static int userChoice;
    private static char reEnterChoice;
    static void Main(string[] args)
    {
        
        while (isProgramRunning)
        {
            Options();
        }
    }

    static char ReEnter()
    {
        return reEnterChoice = Char.Parse(Console.ReadLine());
    }

    static bool Options()
    {
        Console.WriteLine("1: Show products\t2: Override existing products products\n3: Exit");
        userChoice = Int32.Parse(Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                Console.WriteLine("You entered 1: Show products.");
                ProductController.Index();
                break;
            case 2: 
                Console.WriteLine("You entered 2: Override existing products data.");
                ProductController.Store();
                break;
            case 3:
                Console.WriteLine("Program Terminated.");
                isProgramRunning = false;
                break;
            default:
                Console.WriteLine("Choice is invalid. Enter a valid choice.");
                Options();
                break;
        }
        
        Console.WriteLine("Would you like to enter again? [y/n]");
        var reEnter = ReEnter();
        if (Char.ToLower(reEnter) == 'y')
        { 
            return isProgramRunning = true;
        } else if (Char.ToLower(reEnter) == 'n')
        {
            Console.WriteLine("Program terminated.");
            return isProgramRunning = false;
        }
        else
        {
            ReEnter();
        }
        
        return isProgramRunning;
    }
}