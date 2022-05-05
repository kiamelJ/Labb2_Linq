using System;
using System.Collections.Generic;
using DBManyToManyTest1.Models;
using System.Text;
using System.Linq;

namespace DBManyToManyTest1
{
    public class Handler
    {
        //Simple menu to test functionality

        public static bool MainMenu()
        {

            Console.Clear();
            Console.WriteLine("Choose functionality: \r\n");
            Console.WriteLine("1) Show teacher in course Programmering 1");
            Console.WriteLine("2) Show all students with respective teacher");
            Console.WriteLine("3) Show all students for course Programmering 1 and their teacher");
            Console.WriteLine("4) Edit subject from Programmering 2 to OOP");
            Console.WriteLine("5) Update teacher in course Programmering 1 from Anas to Reidar");
            Console.WriteLine("6) Exit");

            Console.WriteLine("\r\nYour choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    GetTeacherPrg1();
                    return true;
                case "2":
                    GetStudentsWithTeacher();
                    return true;
                case "3":
                    GetStudentsPrg1WithTeacher();
                    return true;
                case "4":
                    Console.WriteLine("Please enter new name for subject Programmering 2");
                    var newCourseName = Console.ReadLine();
                    UpdateCourseName(newCourseName);
                    return true;
                case "5":
                    UpdateCourseTeacher();
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }


        public static void GetTeacherPrg1()
        {
            Console.Clear();
            ContextHandler context = new ContextHandler();

            var teacher = (from t in context.Teachers
                           join tc in context.Teacher_Courses
                           on t.Id equals tc.TeacherId

                           join c in context.Courses
                           on tc.CourseId equals c.Id
                           where c.Name == "Programmering 1"

                           select new
                           {
                               TeacherName = t.Name
                           }
                           ).ToList();

            foreach (var item in teacher)
            {
                Console.WriteLine($"Current teacher in Programmering 1 is {item.TeacherName}");
            }
            Console.ReadLine();
        }

        public static void GetStudentsWithTeacher()
        {
            Console.Clear();
            ContextHandler context = new ContextHandler();

            var studentTeacher = (from s in context.Students
                                  join cs in context.Course_Students
                                  on s.Id equals cs.StudentId

                                  join c in context.Courses
                                  on cs.CourseId equals c.Id

                                  join tc in context.Teacher_Courses
                                  on c.Id equals tc.CourseId

                                  join t in context.Teachers
                                  on tc.TeacherId equals t.Id
                                  select new
                                  {
                                      StudentName = s.Name,
                                      TeacherName = t.Name

                                  }).ToList();

            foreach (var item in studentTeacher)
            {
                Console.WriteLine($"Elev: {item.StudentName}. Lärare: {item.TeacherName}");
            }

            Console.ReadLine();
        }

        public static void GetStudentsPrg1WithTeacher()
        {
            Console.Clear();
            ContextHandler context = new ContextHandler();

            var studentTeacherPrg1 = (from s in context.Students
                                      join cs in context.Course_Students
                                      on s.Id equals cs.StudentId

                                      join c in context.Courses
                                      on cs.CourseId equals c.Id

                                      join tc in context.Teacher_Courses
                                      on c.Id equals tc.CourseId

                                      join t in context.Teachers
                                      on tc.TeacherId equals t.Id

                                      where c.Name == "Programmering 1"
                                      select new
                                      {
                                          StudentName = s.Name,
                                          TeacherName = t.Name

                                      }).ToList();

            foreach (var item in studentTeacherPrg1)
            {
                Console.WriteLine($"Elev: {item.StudentName}. Lärare: {item.TeacherName}");
            }

            Console.ReadLine();
        }

        public static void UpdateCourseName(string courseName)
        {
            Console.Clear();
            ContextHandler context = new ContextHandler();

            var subject = context.Courses.Where(c => c.Name == "Programmering 2").First();
            subject.Name = courseName;
            context.SaveChanges();
            Console.WriteLine($"Ämnet är uppdaterat till {subject.Name}");

            Console.ReadLine();
        }

        public static void UpdateCourseTeacher()
        {
            Console.Clear();
            ContextHandler context = new ContextHandler();

            Console.WriteLine("Please choose new teacher for course Programmering 1 from employee list below:\r\n");
            var teacherList = context.Teachers.ToList();

            var num = 1;
            foreach (var item in teacherList)
            {
                Console.WriteLine(@$"{num++}) {item.Name}");
            }

            Console.Write("\r\nEnter new teacher (1-3):");

            var newTeacher = Int32.Parse(Console.ReadLine());

            var teacherToUpdate = (from s in context.Teachers
                                   join ts in context.Teacher_Courses
                                   on s.Id equals ts.TeacherId

                                   join c in context.Courses
                                   on ts.CourseId equals c.Id
                                   where ts.CourseId == 1
                                   select ts).ToList();

            foreach (var item in teacherToUpdate)
            {
                context.Remove(item);
                context.Add(new Teacher_Courses { TeacherId = newTeacher, CourseId = 1 });
                context.SaveChanges();
            }

            Console.WriteLine("Teacher is updated!");
            Console.ReadLine();
        }
    }
}
