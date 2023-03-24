namespace project04
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                Console.Write("Enter first number=> "); int.TryParse(Console.ReadLine(), out int firstNum);
                Console.Write("Enter second number=> "); int.TryParse(Console.ReadLine(), out int secondNum);

                if (firstNum != secondNum) Console.WriteLine(firstNum + secondNum);
                else Console.WriteLine((firstNum + secondNum) * 3);
                Console.WriteLine();
            }
        }
    }
}