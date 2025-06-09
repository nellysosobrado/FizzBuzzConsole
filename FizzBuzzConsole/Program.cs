namespace FizzBuzzConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menuChoice = 0;

            while (true)
            {
                menuChoice = ShowMenu();
                if (menuChoice == 0)
                    break;
                Run(menuChoice);
            }
            static int ShowMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose from the menu below");
                Console.WriteLine("1: Input one number (int): ");
                Console.WriteLine("2: Run FizzBuzz from 1-100");
                Console.WriteLine("0: Exit");
                return Convert.ToInt32(Console.ReadLine());
            }


            static void Run(int menuChoice)
            {
                long num = 0;
                var runFizzBuzz = new FizzBuzz();

                if (menuChoice == 1)
                {
                    Console.WriteLine("Please choose a whole number: ");
                    num = Convert.ToInt64(Console.ReadLine());
                }

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Result");
                        Console.WriteLine("======");
                        Console.WriteLine(runFizzBuzz.WriteFizzBuzz(num));
                        Console.WriteLine("Press any key to continue: ");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Results");
                        Console.WriteLine("=======");

                        for (int i = 1; i <= 100; i++)
                        {
                            Console.WriteLine(runFizzBuzz.WriteFizzBuzz(i));
                        }
                        Console.WriteLine("Press any key to continue: ");
                        Console.ReadLine();
                        break;

                    default:
                        break;
                }
            }

        }
    }
}
