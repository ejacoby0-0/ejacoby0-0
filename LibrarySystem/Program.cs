using static LibrarySystem.Methods; // Makes use that you can call the methods from a different file

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SampleBooks();

            int option;

            do 
            {

                Console.WriteLine("\nWelcome to the library system");

                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Print title of book in-oder");
                Console.WriteLine("3. Search book by year");
                Console.WriteLine("4. Display the most recent book");
                Console.WriteLine("5. Display the number of books");
                Console.WriteLine("6. Exit");

                Console.Write("\nChoice the option (1-5): ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddBooks();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        SearchByYear();
                        break;
                    case 4:
                        MostRecentBookDisplay();
                        break;
                    case 5:
                        NumberOfBooksDisplayed();
                        break;

                }

            } while (option != 6);

            Console.WriteLine("\nThank you for using the library system\n");

        }
    }
}
