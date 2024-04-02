using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Homework2
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            User user1 = new User("1", "Stefan", 30);
            User user2 = new User("2", "Zoran", 32);
            User user3 = new User("3", "Goran", 45);
            User user4 = new User("4", "Martin", 51);
            User user5 = new User("5", "Bojan", 23);
            

            UserDatabase.Users.AddRange(new List<User>  { user1, user2, user3, user4, user5 }); 
           

           

            Console.WriteLine("Do you want search user by: \n [1] ID \n [2] NAME \n [3] AGE");
            string choise = Console.ReadLine();

            if (choise == "1")
            {
                Console.WriteLine("Enter id to search: ");
                string idInput = Console.ReadLine();
                List<User> users = UserDatabase.Users.Where(x => x.Id.Equals(idInput)).ToList();
                Console.WriteLine(users);

            }
            if (choise == "2")
            {
                Console.WriteLine("Enter name to search: ");
                string nameInput = Console.ReadLine();
                List<User> users = UserDatabase.Users.Where(x => x.Name.ToLower().Equals(nameInput.ToLower())).ToList();
                Console.WriteLine(users);
            }
            if (choise == "3")
            {
                Console.WriteLine("Enter age to search:");
                string ageInput = Console.ReadLine();
                if (int.TryParse(ageInput, out int ageUser));
                List<User> users = UserDatabase.Users.Where(x => x.Age.Equals(ageUser)).ToList();
                Console.WriteLine(users);

            }
            Console.WriteLine("Wrong Input");
        }
    }
}
