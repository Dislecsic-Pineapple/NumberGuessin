static void Main(string[] args)
{
    Random random = new Random();

    int returnValue = random.Next(1,100);
    int Guess = 0;

    Console.WriteLine("Guess a number between 1 & 100");

    while (Guess != returnValue)
    {
        Guess = Convert.ToInt32(Console.ReadLine());

        while (Guess < returnValue)
        {
            Console.WriteLine("Number is Higher");
            Console.ReadLine();
        }
        while (Guess > returnValue)
        {
            Console.WriteLine("Number is Lower");
            Console.ReadLine();
        }
    }
    while (Guess == returnValue)
    {
        Console.WriteLine($"Congrats the answer was {returnValue}");
        Console.ReadLine();
    }
}