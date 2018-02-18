using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.WriteLine("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's id
                    Console.Write("id: ");
                    int newId = int.Parse(Console.ReadLine());

                    students.Add(newStudent, newId);
                }
            } while (newStudent != "");

            // Print roster
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<string, int> student in students)
            {
                sb.Append(student.Key + " (" + student.Value + ")\n");
            }

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
