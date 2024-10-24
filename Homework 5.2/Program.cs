class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a number: ");
            string? input = Console.ReadLine();

            try
            {
                double number = double.Parse(input);
                Console.WriteLine($"You entered: {number}");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: invalid format. Please try again.");
            }
        }
    }
}
