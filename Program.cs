using System.Data.SqlTypes;
using System.Text.Encodings.Web;
using System.Text.Json;
using Skola.Models;

namespace Skola;

class Program {
    static void Main() {
        var courses = new List<Course>();

        // Course 1
        var course = new Course();
        course.CourseId = 1;
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
            CourseNumber = "Sv24-00-00",
            Duration = "2 veckor",
            Start = DateTime.Today,
            End = DateTime.Today,
            Place = "Distans"
        };

        courses.Add(course);


        // Course 2
        course = new Course();
        course.CourseId = 136;
        course.Title = "Spanska";
        course.Teacher = new Teacher {
            FirstName = "Greta",
            LastName = "May",
            Email = "gr3tish@gmail.se",
            Id = 1,
            Skills = "Spanska",
            Courses = "Spanska"
        };
        course.CourseSpec = new CourseSpec {
            CourseNumber = "Sp24-00-00",
            Duration = "2 veckor",
            Start = DateTime.Today,
            End = DateTime.Today,
            Place = "Distans"
        };
        
        courses.Add(course);




        var path = string.Concat(Environment.CurrentDirectory, "/Data/Courses.json");
        JsonStorage.WriteJson(path, courses);

        var coursesFromFile = JsonStorage.ReadJs(path);

        Console.WriteLine("");
        Console.WriteLine("Kurser:");
        
        foreach(var jsonCourse in coursesFromFile){
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine(jsonCourse);
            Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Personal ID: #{course.Teacher.Id}, Lärare: {course.Teacher.FirstName} {course.Teacher.LastName}");
            
        }
        
        Console.ResetColor();
    }
}
