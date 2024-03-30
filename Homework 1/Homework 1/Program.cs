using Service;

namespace Homework_1
{
    public class Program
    {
        static void Main(string[] args)
        {

            string webText = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout";

            string text = "Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy";


            ISearchable searchable;
            while (true)
            {
                Console.WriteLine("What would you like to search [1]Document or [2]WebPage");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    searchable = new Document(text);
                    Console.WriteLine("Please enter word to search");
                    string wordInput = Console.ReadLine();
                    Console.WriteLine(searchable.Search(wordInput));
                }
                else if (input == "2")
                {
                    searchable = new WebPage(webText);
                    Console.WriteLine("Please enter word to search");
                    string wordInput = Console.ReadLine();
                    Console.WriteLine(searchable.Search(wordInput));
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    break;
                }

                Console.WriteLine("Would you like to search again Y or N");
                string userInput = Console.ReadLine();
                if (userInput.ToUpper() == "Y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thank you for using our app");
                    break ;
                }

            }
            
        }
    }
    
}
