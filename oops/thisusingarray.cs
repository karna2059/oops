using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace oops
    {
        class student
        {
            int id;
            string name;
            string email;

            public student(int id, string name, string email)
            {
                this.id = id;
                this.name = name;
                this.email = email;
            }

            public void display()
            {
                Console.WriteLine("Student id is : " + id);
                Console.WriteLine("Student name is : " + name);
                Console.WriteLine("Student email is : " + email);
                Console.WriteLine("---------------------------");
            }
        }

        internal class thisexample
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter number of students:");
                int n = Convert.ToInt32(Console.ReadLine());

                // Array of student objects
                student[] s = new student[n];

                // Input from user
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter student id:");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter student name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter student email:");
                    string email = Console.ReadLine();

                    // Store object in array
                    s[i] = new student(id, name, email);
                }

                // Display all students
                Console.WriteLine("\nStudent Details");

                for (int i = 0; i < n; i++)
                {
                    s[i].display();
                }
            }
        }
    }
   