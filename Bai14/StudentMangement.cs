using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bai14
{
    public class StudentMangement
    {
         List<Student> students = new List<Student>();
        public string fileName = "GoodStudents.json";
        public string fileName2 = "NormalStudents.json";
        public List<Student> GetStudents()
        {
            LoadGoodStudentFromFile();
            LoadNormalStudentFromFile();
            return students;
        }

        public List<Student> LoadGoodStudentFromFile()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    string jsonData = File.ReadAllText(fileName);
                    List<GoodStudent> goodStudents = JsonSerializer.Deserialize<List<GoodStudent>>(jsonData);
                    if (goodStudents.Count == 0)
                    {
                        throw new InvalidInput();
                    }
                    foreach(var goodStudent in goodStudents)
                    {
                        students.Add(goodStudent);
                    }
                    return students;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;

        }
        public List<Student> LoadNormalStudentFromFile()
        {
            try
            {
                if (File.Exists(fileName2))
                {
                    string jsonData = File.ReadAllText(fileName2);
                    List<NormalStudent> normalStudents = JsonSerializer.Deserialize<List<NormalStudent>>(jsonData);
                    if (normalStudents.Count == 0)
                    {
                        throw new InvalidInput();
                    }
                    foreach (NormalStudent normalStudent in normalStudents)
                    {
                        students.Add(normalStudent);
                    }
                    return students;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;

        }
        
        public List<GoodStudent> GetAllGoodStudents(List<Student> students)
        {
            List<GoodStudent> studentsList = new List<GoodStudent>();
            foreach (var student in students)
            {
                if (student.GetType() == typeof(GoodStudent))
                {
                    studentsList.Add((GoodStudent)student);
                }
            }
            return studentsList;
        }
        public List<NormalStudent> GetAllNormalStudents(List<Student> students)
        {
            List<NormalStudent> studentsList = new List<NormalStudent>();
            foreach (var student in students)
            {
                if (student.GetType() == typeof(NormalStudent))
                {
                    studentsList.Add((NormalStudent)student);
                }
            }
            return studentsList;
        }
    }
    
}
