using static Student_Course_Enrollment_System.Methods;

namespace Student_Course_Enrollment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods.AddSampleData();

            int choice;

            Console.WriteLine("Welcome to the Student Course Enrollment System (SCES)\n");

            Console.WriteLine("\n-------------------SCES Menu:----------------------------");

            // do while loop to loop the choices until 5 is selected to end the program
            do
            {
                //Menu
                Console.WriteLine("\n1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Display Student");
                Console.WriteLine("4. Print Student Information to File");
                Console.WriteLine("5. Exit");

                //prompting user for their choice
                Console.Write("\nEnter your choice (1-4): ");
                choice = Convert.ToInt32(Console.ReadLine());

                //Switch case for selecting the choices
                switch (choice)
                {
                    case 1:
                        Methods.AddStudent();
                        break;
                    case 2:
                        Methods.RemoveStudent();
                        break;
                    case 3:
                        Methods.DisplayStudents();
                        break;
                    case 4:
                        Methods.TextFile();
                        break;
                }

            } while (choice != 5);

            Console.WriteLine("\nThank you for using SCES :)");
            Console.WriteLine("-------------------End of SCES----------------------------");

        }
    }
}
