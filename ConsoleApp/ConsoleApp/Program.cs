namespace ConsoleApp
{
     class Program
    {
             
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter a sring");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            Addition();
        }

        public static void Addition()
        {
            Console.WriteLine("Enter 2 numbers to add");
            Console.WriteLine("Enter first number to add");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number to add");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);

        }

    }
}