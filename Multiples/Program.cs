class Multiples
{
    static void Main(string [] args)
    {
        // declaring variables
        int firstNumber;
        int secondNumber;

        // prompting user to get input for first number
        Console.Write("Enter First Number:  ");
        firstNumber = Convert.ToInt32 (Console.ReadLine());

        // prompting user to get input for second number
        Console.Write("Enter Second Number:  ");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // if the second number is fully divisible by first number than it a multiple of second number
        if (firstNumber % secondNumber == 0)
        {
            Console.WriteLine(firstNumber + " Is A Multiple Of " + secondNumber);
        }

        else
        {
            Console.WriteLine(firstNumber + " Is Not A Multiple Of " + secondNumber);
        }
    }
    // end of Main method
}
// end of Multiples class
