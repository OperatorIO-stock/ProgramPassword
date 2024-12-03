namespace ProgramPassword;

class Program
{
    static void Main(string[] args)
    {
        string userPassword = "1234";
        string userAnswer;

        int numberOfAttempts = 2;

        Console.WriteLine("Welcome to the Program\nEnter the password:");

        for (int i = numberOfAttempts; i >= 0; i--)
        {
            userAnswer = Console.ReadLine();

            if(userAnswer != userPassword)
            {
                Console.WriteLine("Access denied\n" +
                                    $"There are still attempts left: {i}");
            }
            else
            {
                Console.WriteLine("Secret message...");
                break;
            }
        }
    }
}
