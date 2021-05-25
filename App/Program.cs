using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SchoolContext();

            //1
            Console.WriteLine("Displaying All Students");
            foreach(var student in db.Students){
                Console.WriteLine($"{student.Id} : {student.LastName}, {student.FirstName}");
            }

            //2
            Console.WriteLine("Querying for Rick and his grades");
            Student student1 = db.Students.Where(Student => Student.FirstName == "Rick").FirstOrDefault();

            Console.WriteLine($"{student1.FirstName} : {student1.LastName}");

            db.Grades.Where(grade => grade.StudentId == student1.Id).ToList().ForEach((Grade grade) => 
            Console.WriteLine($"{grade.CourseName} : {grade.GradeP}")
            );

            //3
            Console.WriteLine("Querying for Rick and his grades");
            var grades3 = db.Grades.Where(grade => grade.StudentId == student1.Id).ToList().Average(grade => grade.GradeP);
            Console.WriteLine($"Rick's average grade is {grades3}");

            //4
            Console.WriteLine("Querying for student with highest average grade");

            var studentAllGrades = db.Grades
            .GroupBy(g => g.StudentId)
            .Select(g => new {
                StudentId = g.Key, 
                Average = g.Average(a => a.GradeP),
                Count = g.Count()
                })
            .Join(
                db.Students,
                g => g.StudentId,
                s => s.Id,
                (grade, student) => new {
                    Id = student.Id,
                    Name = student.FirstName + " " + student.LastName,
                    Year = student.classification,
                    Avg = grade.Average,
                    Count = grade.Count,
                }
            );

            var highAvgStudent = studentAllGrades.OrderByDescending(o => o.Avg).FirstOrDefault();

            Console.WriteLine($"The max average is {highAvgStudent.Avg} from student {highAvgStudent.Name}");


        }
    }
}
