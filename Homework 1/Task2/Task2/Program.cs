namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager ("Stefan", 10000);
            var programer = new Programmer ("Trpe", 5000);
            

            Console.WriteLine($"{manager.DisplayInfo()}");
            Console.WriteLine($"{manager.CalculateSalary()}");

            Console.WriteLine($"{programer.DisplayInfo()}");
            Console.WriteLine($"{programer.CalculateSalary()}");
        }
    }
}
