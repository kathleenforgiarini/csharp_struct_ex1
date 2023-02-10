using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// CODED BY KATHLEEN FORGIARINI DA SILVA

namespace lab3_struct
{
    //Creating struct for Person
    struct Person
    {
        public string first_name;
        public string last_name;
        public sbyte age;
    }

    //Creating struct for Student
    struct Student
    {
        public Person pData; // object of Person struct
        public uint id;
        public string college_name;
        public string city;
        public string address;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            char option;
            Student st1 = new Student();
            Student st2 = new Student();

            // Inicializing the operation
            do
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("1) Add nem student");
                Console.WriteLine("2) Display students");
                Console.WriteLine("0) Exit application");
                option = Convert.ToChar(Console.ReadLine()); //Convert string to char
                switch (option)
                {
                    case '1':
                        // If there is nothing created for student 1, create on student 1
                        if(st1.pData.first_name == null)
                        {
                            //Enter the informations

                            Console.WriteLine("Enter student's first name: ");
                            st1.pData.first_name = Console.ReadLine();

                            Console.WriteLine("Enter student's last name: ");
                            st1.pData.last_name = Console.ReadLine();

                            age: //label for goto

                            // If the age entered is not supported by SByte
                            try
                            {
                                Console.WriteLine("Enter student's age: ");
                                st1.pData.age = Convert.ToSByte(Console.ReadLine());
                                if (st1.pData.age < 21 || st1.pData.age > 85)
                                {
                                    Console.WriteLine("Please enter a value between 21 and 85");
                                    goto age; //if the age is not between 21 and 85, go back to ask again
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Oh no! An exception occurred.\n - Details: " + e.Message);
                                goto age;
                            }

                            id: // label for goto

                            // If the ID entered is not supported by Int32
                            try
                            {
                                Console.WriteLine("Enter student's ID: ");
                                st1.id = Convert.ToUInt32(Console.ReadLine());
                                if (st1.id.ToString().Length > 7)
                                {
                                    Console.WriteLine("Enter a number less than 7 digits");
                                    goto id;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Oh no! An exception occurred.\n - Details: " + e.Message);
                                goto id;
                            }

                            Console.WriteLine("Enter college's name: ");
                            st1.college_name = Console.ReadLine();
                            Console.WriteLine("Enter the city: ");
                            st1.city = Console.ReadLine();
                            Console.WriteLine("Enter the address: ");
                            st1.address = Console.ReadLine();
                        }
                        else  // If there is something created for student 1, create on student 2
                        {
                            //Enter the informations

                            Console.WriteLine("Enter student's first name: ");
                            st2.pData.first_name = Console.ReadLine();

                            Console.WriteLine("Enter student's last name: ");
                            st2.pData.last_name = Console.ReadLine();

                            age: //label for goto

                            // If the age entered is not supported by SByte
                            try
                            {
                                Console.WriteLine("Enter student's age: ");
                                st2.pData.age = Convert.ToSByte(Console.ReadLine());
                                if (st2.pData.age < 21 || st2.pData.age > 85)
                                {
                                    Console.WriteLine("Please enter a value between 21 and 85");
                                    goto age; //if the age is not between 21 and 85, go back to ask again
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Oh no! An exception occurred.\n - Details: " + e.Message);
                                goto age;
                            }

                            id: // label for goto

                            // If the ID entered is not supported by Int32
                            try
                            {
                                Console.WriteLine("Enter student's ID: ");
                                st2.id = Convert.ToUInt32(Console.ReadLine());
                                if (st2.id.ToString().Length > 7)
                                {
                                    Console.WriteLine("Enter a number less than 7 digits");
                                    goto id;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Oh no! An exception occurred.\n - Details: " + e.Message);
                                goto id;
                            }

                            Console.WriteLine("Enter college's name: ");
                            st2.college_name = Console.ReadLine();
                            Console.WriteLine("Enter the city: ");
                            st2.city = Console.ReadLine();
                            Console.WriteLine("Enter the address: ");
                            st2.address = Console.ReadLine();
                        }

                        break;

                    case '2':
                        if (st1.pData.first_name == null && st2.pData.first_name == null)
                        {
                            Console.WriteLine("There is nothing to display!\n");
                        }
                        else if (st1.pData.first_name == null && st2.pData.first_name != null)
                        {
                            //Display all the information
                            Console.WriteLine("\n Student 2: ");
                            Console.WriteLine("\nFirst name: {0,-15} Last name: {1,-15} Age: {2,5}", st2.pData.first_name, st2.pData.last_name, st2.pData.age);
                            Console.WriteLine("ID: {0}, College: {1}, City: {2}, Address: {3}\n", st2.id, st2.college_name, st2.city, st2.address);
                        }
                        else if (st1.pData.first_name != null && st2.pData.first_name == null) {
                            //Display all the information
                            Console.WriteLine("\n Student 1: ");
                            Console.WriteLine("\nFirst name: {0,-15} Last name: {1,-15} Age: {2,5}", st1.pData.first_name, st1.pData.last_name, st1.pData.age);
                            Console.WriteLine("ID: {0}, College: {1}, City: {2}, Address: {3}\n", st1.id, st1.college_name, st1.city, st1.address);
                        }
                        else
                        {
                            Console.WriteLine("\n Student 1: ");
                            Console.WriteLine("\nFirst name: {0,-15} Last name: {1,-15} Age: {2,5}", st1.pData.first_name, st1.pData.last_name, st1.pData.age);
                            Console.WriteLine("ID: {0}, College: {1}, City: {2}, Address: {3}\n", st1.id, st1.college_name, st1.city, st1.address);
                            Console.WriteLine("\n Student 2: ");
                            Console.WriteLine("\nFirst name: {0,-15} Last name: {1,-15} Age: {2,5}", st2.pData.first_name, st2.pData.last_name, st2.pData.age);
                            Console.WriteLine("ID: {0}, College: {1}, City: {2}, Address: {3}\n", st2.id, st2.college_name, st2.city, st2.address);
                        }
                        break;
                    case '0':
                        break;
                    default: break;
                } // end switch

            } while (option != '0');
        } // end main
    }
}
