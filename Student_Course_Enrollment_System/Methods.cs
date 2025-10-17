using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment_System
{
    internal class Methods
    {

        //The linkedList<Student> field linked the list of each node that contains student object, it is more dynamic then a array
        //Store student objects that is shared between the classes
        static public List<Student> studentRecords = new List<Student>();

        public class Student
        {
            public string Name { get; set; }
            public string  Id { get; set; }

        }

        //Sample data
        public static void AddSampleData()
        {
            studentRecords.Add(new Student { Name = "Sarah Mokoena", Id = "S001" });
            studentRecords.Add(new Student { Name = "Thabo Ndlovu", Id = "S002" });
            studentRecords.Add(new Student { Name = "Nomsa Dlamini", Id = "S003" });
            studentRecords.Add(new Student { Name = "Kebelo Molefe", Id = "S004" });
            studentRecords.Add(new Student { Name = "Lerato Khumalo", Id = "S005" });
            studentRecords.Add(new Student { Name = "Siphiwe Ntuli", Id = "S006" });
            studentRecords.Add(new Student { Name = "Ayanda Zulu", Id = "S007" });
            studentRecords.Add(new Student { Name = "Boitumelo Mthembu", Id = "S008" });
            studentRecords.Add(new Student { Name = "Tshepo Mabena", Id = "S009" });
            studentRecords.Add(new Student { Name = "Zanele Hlophe", Id = "S010" });
        }


        //1. Function for adding students
        public static void AddStudent()
        {
            Console.Write("\nEnter student name: ");
            string name = Console.ReadLine();

            Console.Write($"\nWhat is the ID for {name}: ");
            string id = Console.ReadLine();

            //Creates a new object for the patient class & assign variable newPatient
            Student newStudent = new Student
            {
                Name = name,
                Id = id
            };

            //NewStudents are added to the end of the studentRecords linked list
            studentRecords.Add(newStudent);

            Console.WriteLine("\nStudnet added successfully");

        }


        //2. Function for removing students
        public static void RemoveStudent()
        {
            Console.Write("\nEnter the name of the student that you want to remove: ");
            string nameRemove = Console.ReadLine();

            // Use List<T>.FindIndex / RemoveAt or RemoveAll
            int idx = studentRecords.FindIndex(s => s.Name.Equals(nameRemove, StringComparison.OrdinalIgnoreCase));
            if (idx >= 0)
            {
                studentRecords.RemoveAt(idx);
                Console.WriteLine("\nStudent removed successfully");
                return;
            }

            Console.WriteLine("\nStudent does not exist");
        }


        //3. Function for displaying students
        public static void DisplayStudents()
        {
            if (studentRecords.Count == 0)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                Console.WriteLine("\nEnrolled Students:");
                foreach (var student in studentRecords)
                {
                    Console.WriteLine($"Name: {student.Name}, ID: {student.Id}");
                }
            }
        }


        // 4. Printing data to text file
        public static void TextFile(string filePath = "student_information.txt")
        {
            // Using statement automatically closes the file
            // Writes all the student data to the file & creates an object for writing text
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false)) // false = overwrite; use true to append
                {
                    if (studentRecords.Count == 0)
                    {
                        writer.WriteLine("No students enrolled.");
                    }
                    else
                    {
                        foreach (var student in studentRecords)
                        {
                            string studentData = $"Name: {student.Name}, Id: {student.Id}";
                            writer.WriteLine(studentData);
                        }
                    }
                }

                Console.WriteLine($"Student information printed to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

    }
}
