using System.Data.SqlTypes;
using System.Text.Encodings.Web;
using System.Text.Json;
using Skola.Models;

namespace Skola;

class Program {
    static void Main() {
        var courses = new List<Course>();
        // var teachers = new List<Teacher>();
        // var pathTeachers = string.Concat(Environment.CurrentDirectory, "/Data/Teachers.json");


        // var teacher = new Teacher() {
        //     Id = 1,
        //     FirstName = "Jan",
        //     LastName = "Hansson",
        //     Email = "janne@gmail.se",
        //     Skills = "C#, Javascript, HTML, CSS, JS",
        //     Courses = "Svenska"
        // };
        // teachers.Add(teacher);
        // teacher = new Teacher() {
        //     Id = 3,
        //     FirstName = "Janne",
        //     LastName = "Hansson",
        //     Email = "janne@gmail.se",
        //     Skills = "C#, Javascript, HTML, CSS, JS",
        //     Courses = "Svenska"
        // };
        // teachers.Add(teacher);

        // Course 1
        var course = new Course();
        course.CourseNumber = 1;
        course.Title = "Svenska";
        course.Teacher = new Teacher {
            FirstName = "Janne",
            LastName = "Hansson",
            Email = "janne@gmail.se",
            Id = 1,
            Skills = "C#, Javascript, HTML, CSS, JS",
            Courses = "Svenska"
        };
        course.CourseSpec = new CourseSpec {
            CourseId = "Sv24-00-00",
            Duration = "2 veckor",
            Start = DateTime.Today,
            End = DateTime.Today.AddDays(14),
            Place = "Klassrum"
        };

        courses.Add(course);


        // Course 2
        course = new Course();
        course.CourseNumber = 2;
        course.Title = "Nätverksprogrammering";
        course.Teacher = new Teacher {
            FirstName = "Sven",
            LastName = "Svensson",
            Email = "Svenne@gmail.se",
            Id = 2,
            Skills = "It",
            Courses = "Nätverksprogrammering"
        };
        course.CourseSpec = new CourseSpec {
            CourseId = "ITPR-24-06",
            Duration = "3 Years",
            Start = DateTime.Today,
            End = DateTime.Today.AddYears(3),
            Place = "Distans"
        };
        courses.Add(course);

        // Course 3
        course = new Course();
        course.CourseNumber = 136;
        course.Title = "Spanska";
        course.Teacher = new Teacher {
            FirstName = "Greta",
            LastName = "May",
            Email = "gr3tish@gmail.se",
            Id = 3,
            Skills = "Spanska",
            Courses = "Spanska"
        };
        course.CourseSpec = new CourseSpec {
            CourseId = "Sp24-00-00",
            Duration = "6 Månader",
            Start = DateTime.Today,
            End = DateTime.Today.AddMonths(6),
            Place = "Distans"
        };
        courses.Add(course);



        // JsonStorage.WriteJsonTeachers(pathTeachers, teachers);
        // var coursesFromFile = JsonStorage.ReadJs(pathTeachers);
        // Console.WriteLine("");
        // Console.WriteLine("Lärare:");
        // foreach(var jsonTeacher in coursesFromFile){
        //     Console.ForegroundColor = ConsoleColor.Yellow;
        //     Console.WriteLine("");
        //     Console.WriteLine(jsonTeacher);
        //     Console.ForegroundColor = ConsoleColor.Blue;
        //         Console.WriteLine($"Personal ID: #{course.Teacher.Id}, Lärare: {course.Teacher.FirstName} {course.Teacher.LastName}");
            
        // }


        var path = string.Concat(Environment.CurrentDirectory, "/Data/Courses.json");
        JsonStorage.WriteJson(path, courses);

        var coursesFromFile = JsonStorage.ReadJs(path);

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Kurser:");
        
        foreach(var jsonCourse in coursesFromFile){
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Kurs: {jsonCourse.Title} - #{jsonCourse.CourseNumber}");
            Console.WriteLine("Kursinfo:");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            
            Console.WriteLine($" Kursid: {jsonCourse.CourseSpec.CourseId} \n Längd: {jsonCourse.CourseSpec.Duration} \n Start: {jsonCourse.CourseSpec.Start} \n Avslut: {jsonCourse.CourseSpec.End} \n Plats: {jsonCourse.CourseSpec.Place} \n Lärare: {jsonCourse.Teacher.FirstName} {jsonCourse.Teacher.LastName} ");
            Console.ResetColor();
            Console.WriteLine("---------------------------------------");
        }
        
        
    }
}
