using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentMangement studentMangement = new StudentMangement();
            List<Student> students = new List<Student>();
            Console.WriteLine("Student Management");
            while (true)
            {
                Console.WriteLine("1: Get students from file ");
                Console.WriteLine("2: Select students ");
                Console.WriteLine("3: List all students ");
                Console.WriteLine("4: Exit ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            students = studentMangement.GetStudents();
                            try
                            {
                                foreach(Student student in students)
                                {
                                    Validation.ValidateName(student.FullName);
                                    Validation.ValidatePhoneNumber(student.PhoneNumber);
                                    Validation.ValidateDate(student.DoB.ToString());
                                }
                            }
                            catch (InvalidFullNameException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (InvalidDOBException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (InvalidPhoneNumberException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (InvalidInput ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    case "2":
                        {

                            Console.WriteLine("Enter number of students to select: ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            List<GoodStudent> goodStudents = studentMangement.GetAllGoodStudents(students);
                            List<NormalStudent> normalStudents = studentMangement.GetAllNormalStudents(students);
                            normalStudents.OrderByDescending(s => s.EnglishScore).ThenBy(s=>s.FullName);
                            List<Student> selectedStudents = new List<Student>();
                            int numberOfGoodStudent = goodStudents.Count;
                            if (number <= numberOfGoodStudent)
                            {
                                goodStudents.OrderByDescending(s => s.Gpa).ThenBy(s => s.FullName);
                                for(int i=0;i<number; i++)
                                {
                                    selectedStudents.Add(goodStudents[i]);
                                }
                            }
                            else if(number> numberOfGoodStudent && number<students.Count)
                            {
                                selectedStudents.AddRange(goodStudents);
                                int numberOfNormalStudents = number - numberOfGoodStudent;
                                for(int i = 0; i < numberOfNormalStudents; i++)
                                {
                                    selectedStudents.Add(normalStudents[i]);
                                }
                            }
                            else
                            {
                                selectedStudents = students;
                            }
                            
                                try
                                {
                                    string jsonData = JsonSerializer.Serialize(selectedStudents, new JsonSerializerOptions { WriteIndented = true });
                                    File.WriteAllText("SelectedStudents.json", jsonData);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception(ex.Message);
                                }
                            
                            break;
                        }
                    case "3":
                        {
                            students.OrderByDescending(s => s.FullName).ThenBy(s => s.PhoneNumber);
                            foreach(var student in students)
                            {
                                Console.WriteLine(student.ShowMyInfo());
                            }
                            break;
                        }
                    case "4":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter between 1 and 4");
                            continue;
                        }
                }
            }
        }
    }
}
