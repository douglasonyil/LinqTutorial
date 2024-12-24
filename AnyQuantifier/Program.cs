using System;
using System.Collections;
using System.Linq;

namespace AnyQuantifier
{

    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectMarks { get; set; }
    }

    public class Student
    {
        public string? Name { get; set; }
        public int Marks { get; set; }

        public List<Subject> Subjects { get; set; }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Student[] students =
                {
                new Student{ Name = "Kim", Marks = 90, Subjects = new List<Subject>()
                    {
                    new Subject(){SubjectName = "Math", SubjectMarks = 75},
                    new Subject(){SubjectName = "English", SubjectMarks = 80},
                    new Subject(){SubjectName = "Art", SubjectMarks = 86},
                    new Subject(){SubjectName = "History", SubjectMarks = 91},
                    }
                },
                new Student{ Name = "John", Marks = 80, Subjects = new List<Subject>()
                    {
                    new Subject(){SubjectName = "Math", SubjectMarks = 89},
                    new Subject(){SubjectName = "English", SubjectMarks = 91},
                    new Subject(){SubjectName = "Art", SubjectMarks = 90},
                    new Subject(){SubjectName = "History", SubjectMarks = 91}
                    }
                },
                new Student{ Name = "Lee", Marks = 75, Subjects = new List<Subject>()
                    {
                    new Subject(){SubjectName = "Math", SubjectMarks = 75},
                    new Subject(){SubjectName = "English", SubjectMarks = 80},
                    new Subject(){SubjectName = "Art", SubjectMarks = 60},
                    new Subject(){SubjectName = "History", SubjectMarks =92}
                    }
                }

                };

            var st = students.Where(std => std.Subjects.Any(x => x.SubjectMarks > 90)).
                        Select(std => std.Name).ToList();

            var qs = (from student in students
                      where student.Subjects.Any(sub => sub.SubjectMarks >= 92)
                      select student.Name).ToList();



            Console.WriteLine();
        }
    }
    
}


//List<int> numbers = new List<int> { 33, 32, 21, 98, 100 };
//var isAvailable = numbers.ToList();
//Student[] students = { new Student { Name = "Kim", Marks = 90 } },
//                                 { new Student { Name = "John", Marks = 80 } },
//                                 { new Student { Name = "Lee", Marks = 75 } };

//var s = students.ToList();