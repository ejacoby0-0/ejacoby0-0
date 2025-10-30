using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static LibrarySystem.Methods;

namespace LibrarySystem
{
    internal class Methods
    {
        //Creating the book class with their respective propertise
        public class Books
        {
            public string Title;
            public string Author;
            public int Year;

            //The constructure ensures that objects are properly set up and ready for use as soon as they are created.
            public Books(string title, string author, int year)
            {
                Title = title;
                Author = author;
                Year = year;
            }
        }

        //Declaring the List collection to store the book data
        static public List<Books> bookRecords = new List<Books>();

        //The Book sample data
        public static void SampleBooks()
        {

            //Creating a new object for the book class to have data & assign data
            bookRecords = new List<Books>
            {

                new Books("The Silent Patient", "Alex Michaelides", 2019),

                new Books("The Great Gatsby", "F. Scott Fitzgerald", 1925),

                new Books("To Kill a Mockingbird", "Harper Lee", 1960),

                new Books("1984", "George Orwell", 1949),

                new Books("The Catcher in the Rye", "J.D. Salinger", 1951),

                new Books("Pride and Prejudice", "Jane Austen", 1813),

                new Books("Moby-Dick", "Herman Melville", 1851),

                new Books("The Hobbit", "J.R.R. Tolkien", 1937),

                new Books("Brave New World", "Aldous Huxley", 1932),

                new Books("The Book Thief", "Markus Zusak", 2005),

                new Books("The Road", "Cormac McCarthy", 2006),

                new Books("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997),

                new Books("The Girl with the Dragon Tattoo", "Stieg Larsson", 2005),

                new Books("The Alchemist", "Paulo Coelho", 1988),

                new Books("The Shining", "Stephen King", 1977),

                new Books("Wuthering Heights", "Emily Brontë", 1847),

                new Books("Catch-22", "Joseph Heller", 1961),

                new Books("The Hunger Games", "Suzanne Collins", 2008),

                new Books("The Da Vinci Code", "Dan Brown", 2003),

                new Books("The Outsiders", "S.E. Hinton", 1967)


            };
        }

        //1.Add books
        public static void AddBooks()
        {
            Console.Write("\nEnter the title of the book: ");
            string title = Console.ReadLine();

            Console.Write($"\nWho is the author of {title}: ");
            string author = Console.ReadLine();

            Console.Write("\nWhay year did the book get released in: ");
            int year = Convert.ToInt32(Console.ReadLine());

            //Creates a new object for the book class & assign data
            Books newBook = new Books(title, author, year);
            
            //newBooks are added to the end of the nookRecord that is stored to the list
            bookRecords.Add(newBook);

            Console.WriteLine("\nBook added successfully");
        }

        //2. Displaying the books in order
        public static void Display()
        {
            //If there are no books, if won't display
            if (bookRecords.Count == 0)
            {
                Console.WriteLine("Student not found");
            }

            //But if there are book, it will display
            else
            {
                Console.WriteLine("\nBooks sorted by title:");
                foreach (var books in bookRecords)
                {
                    Console.WriteLine($"Title: {books.Title}, Author: {books.Author}, Year: {books.Year}");
                }
            }


        }

        //3. Search for book based on year
        public static void SearchByYear()
        {

            Console.Write("\nEnter the year of the book you want to search for: ");

            //Reads the users input and turns it into a int, however if a user uses letter it will be invalid
            if (!int.TryParse(Console.ReadLine(), out int searchYear))
            {
                Console.WriteLine("Invalid year entered (Please use numeric values)");
                return;
            }

            // This searches through all the data stored in the list (bookRecords) and create a new list (foundBooks)
            var foundBooks = bookRecords.FindAll(b => b.Year == searchYear);

            //If the books (foundBooks) count is greater than 0, is will display the book based on its year
            if (foundBooks.Count > 0)
            {
                Console.WriteLine($"\nBooks published in {searchYear}:");
                foreach (var books in foundBooks)
                {
                    Console.WriteLine($"Title: {books.Title}, Author: {books.Author}");
                }
            }

            //Else if the books (foundBooks) count is less than 0, there is no book based on the year
            else
            {
                Console.WriteLine("\nNo books found for that year.");
            }
        }


        //4. Display the most recent book
        public static void MostRecentBookDisplay()
        {
            //If there are no books, if won't display
            if (bookRecords.Count == 0)
            {
                Console.WriteLine("No books found.");
                return;
            }

            //Initalizing the maxyear and recent books
            int maxYear = int.MinValue;
            Books recentBook = null;

            foreach (var books in bookRecords)
            {
                //if the books stored in the list is geater than maxyear, it will be the recent book
                if (books.Year > maxYear)
                {
                    maxYear = books.Year;
                    recentBook = books;
                }
            }

            //Displaying recent book based on year greater then the pervious books years
            Console.WriteLine($"\nMost recent book:");
            Console.WriteLine($"Title: {recentBook.Title}, Author: {recentBook.Author}, Year: {recentBook.Year}");


        }

        //5. Display the number of books
        public static void NumberOfBooksDisplayed()
        {
            //The data that has been add or stored in the list, will be count by the Count method
            Console.WriteLine($"\nNumber of books in the library: {bookRecords.Count}");

        }
    }
}
