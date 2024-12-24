namespace AllQuantifier
{

    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectMarks { get; set; }
    }
    public class Student
    {
        public string Name { get; set; }
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
                    new Subject(){SubjectName = "History", SubjectMarks =91}
                    }
                }

                };

            var a = students.ToList();

            var ms = students.Where(std => std.Subjects.All(x => x.SubjectMarks > 70)).Select(std => std).ToList();

            var qs = (from std in students
                     where std.Subjects.All(x => x.SubjectMarks >80)
                     select std).ToList();

            foreach (var item in a)
            {
                Console.WriteLine($"Name :{item.Name} Marks: {item.Marks} Subjects: {item.Subjects}");
            }

            Console.WriteLine();
            

        }
    }

    
}


//Student[] students = { new Student { Name = "Kim", Marks = 90 },
//                       new Student { Name = "John", Marks = 80},
//                       new Student { Name = "Lee", Marks = 75}
//};

//var ms = students.All(student => student.Marks > 0);

//var qs = (from student in students
//select student).All(x => x.Marks > 70);

//Console.WriteLine();