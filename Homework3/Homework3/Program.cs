namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PrintInConsole.Print("Hello, world!");
            PrintInConsole.Print(555);

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            PrintInConsole.PrintCollection(numbers);

            List<string> names = new List<string> { "Stefan", "Mitko", "Goran" };
            PrintInConsole.PrintCollection<string>(names);
        }
    }
}
