namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "Files";
            string filePath = $@"{folderPath}\names.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);

            }

            if (!File.Exists(filePath))
            {
                var file = File.Create(filePath);
                file.Close();
            }
            var names = new List<string>();


            using (var file = new StreamWriter(filePath, true))
            {
                while (true)
                {

                    Console.WriteLine("Please write some name");
                    string name = Console.ReadLine();
                    names.Add(name);

                    Console.WriteLine("Do you want add another name Y or N");
                    string option = Console.ReadLine();

                    
                    if (option == "N")
                    {
                        break;
                    }

                    
                }

                foreach (var i in names)
                {
                    file.WriteLine(i);
                }
            }

            using (var reader = new StreamReader(filePath))
            {
              
                while (true)
                {
                    string text = reader.ReadLine();
                    Console.WriteLine(text);
                    
                    if (text == null)
                    {
                        break;
                    }
                }
            }
        }
            
        











    }
}
