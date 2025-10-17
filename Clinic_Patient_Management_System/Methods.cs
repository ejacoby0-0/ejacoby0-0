using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clinic_Patient_Management_System
{
    //The method class keeps all the functions together
    internal class Methods
    {

        //Defining the patient class to be used in the other functions
        public class Patient
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string MedicalCondition { get; set; }
        }


        //Declaring the array to store the patient data -- The max patient is 10
        static public Patient[] patientRecords = new Patient[10];
        //Keeps track of how many patients there are
        static public int patientCount = 0;

        //The 5 patient sample data
        public static void AddSamplePatients()
        {
            patientRecords[0] = new Patient { Name = "Sarah Mokoena", Age = 34, MedicalCondition = "Hypertension" };
            patientRecords[1] = new Patient { Name = "Thabo Ndlovu", Age = 29, MedicalCondition = "Asthma" };
            patientRecords[2] = new Patient { Name = "Nomsa Dlamini", Age = 41, MedicalCondition = "Diabetes" };
            patientRecords[3] = new Patient { Name = "Kebelo Molefe", Age = 37, MedicalCondition = "High Cholesterol" };
            patientRecords[4] = new Patient { Name = "Lerato Khumalo", Age = 22, MedicalCondition = "Flu" };


            patientCount = 5;
        }



        //1. Adding patient function
        public static void AddPatient()
        {
            if (patientCount >= patientRecords.Length)
            {
                Console.WriteLine("Patient list is full.");
                return;
            }

            Console.WriteLine("\nEnter patient name:");
            string name = Console.ReadLine();

            Console.WriteLine($"\nWhat is the age of {name}:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nWhat is {name} medical condition:");
            string medicalCondition = Console.ReadLine();


            Patient newPatient = new Patient { Name = name, Age = age, MedicalCondition = medicalCondition };
            patientRecords[patientCount] = newPatient;
            patientCount++;
            Console.WriteLine("\nPatient added successfully");


        }



        //2. Removing patient function
        public static void RemovePatient()
        {
            Console.WriteLine("\nEnter the name of the patient you want to remove");
            string nameRemove = Console.ReadLine();

            int index = -1;
            for (int i = 0; i < patientCount; i++)
            {
                if (patientRecords[i].Name.Equals(nameRemove, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                // Shift elements left
                for (int i = index; i < patientCount - 1; i++)
                {
                    patientRecords[i] = patientRecords[i + 1];
                }
                patientRecords[patientCount - 1] = null;
                patientCount--;
                Console.WriteLine("\nPatient removed successfully");
            }
            else
            {
                Console.WriteLine("\nPatient does not exist");
            }



        }



        //3. Searching patient function
        public static void SearchPatient()
        {
            Console.WriteLine("\nEnter the name of the patient to search:");
            string nameSearch = Console.ReadLine();

            for (int i = 0; i < patientCount; i++)
            {
                if (patientRecords[i].Name.Equals(nameSearch, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nPatient found");
                    Console.WriteLine($"Name: {patientRecords[i].Name}");
                    Console.WriteLine($"Age: {patientRecords[i].Age}");
                    Console.WriteLine($"Medical Condition: {patientRecords[i].MedicalCondition}");
                    return;
                }
            }
            Console.WriteLine("\nPatient does not exist");
        }



        //4. Displaying patient function
        public static void DisplayAllPatients()
        {
            if (patientCount == 0)
            {
                Console.WriteLine("Patient not found");
            }
            else
            {
                Console.WriteLine("\nRegistered Patients:");
                for (int i = 0; i < patientCount; i++)
                {
                    Console.WriteLine($"Name: {patientRecords[i].Name}, Age: {patientRecords[i].Age}, Medical Condition: {patientRecords[i].MedicalCondition}");
                }
            }


        }



        //5. Printing data to text file
        public static void TextFile()
        {
            //Using statement automatically closes the file
            //Writes all the patients data to the file & creates an object for writing text
            using (StreamWriter writer = new StreamWriter("patient_information.txt"))
            {
                for (int i = 0; i < patientCount; i++)
                {
                    var patient = patientRecords[i];
                    string patientData = $"Name: {patient.Name}, Age: {patient.Age}, Medical Condition: {patient.MedicalCondition}";

                    //Write the data to the textfile
                    writer.WriteLine(patientData);
                }
            }

            // Display that the print works
            Console.WriteLine("Patient information printed to patient_information.txt");
        }
    }
}
