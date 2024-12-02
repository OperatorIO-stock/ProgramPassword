namespace ProgramPassword;

class Program
{
    static void Main(string[] args)
    {
        string userPassword = "1234";
        string userAnswer;

        int numberOfAttempts = 3;

        Console.WriteLine("Welcome to the Program\nEnter the password:");

        while(numberOfAttempts != 0)
        {
            userAnswer = Console.ReadLine();

            if(userAnswer != userPassword)
            {
                Console.WriteLine("Access denied");
                numberOfAttempts--;
            }
            else
            {
                Console.WriteLine("Secret message...");
            }
        }
    }
}
