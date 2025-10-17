namespace Clinic_Patient_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Calling the patient sample data
            Methods.AddSamplePatients();

            int choice;

            Console.WriteLine("Welcome to the Clinet Patient Mamagement System (CPMS)\n");

            Console.WriteLine("\n-------------------CPMS Menu:----------------------------");

            // do while loop to loop the choices until 5 is selected to end the program
            do
            {
                //Menu
                Console.WriteLine("\n1. Add Patient");
                Console.WriteLine("2. Remove Patient");
                Console.WriteLine("3. Search Patient");
                Console.WriteLine("4. Display All Patients");
                Console.WriteLine("5. Print Patient Information to File");
                Console.WriteLine("6. Exit");

                //prompting user for their choice
                Console.WriteLine("\nEnter your choice (1-6)");
                choice = Convert.ToInt32(Console.ReadLine());

                //Switch case for selecting the choices
                switch (choice)
                {
                    case 1:
                        Methods.AddPatient();
                        break;
                    case 2:
                        Methods.RemovePatient();
                        break;
                    case 3:
                        Methods.SearchPatient();
                        break;
                    case 4:
                        Methods.DisplayAllPatients();
                        break;
                    case 5:
                        Methods.TextFile();
                        break;
                }

            } while (choice != 6);

            Console.WriteLine("\nThank you for using CPMS :)");
            Console.WriteLine("-------------------End of CMPS----------------------------");

        }
    }
}
