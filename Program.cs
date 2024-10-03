using System.Data.SqlTypes;
using Skola.Models;

namespace Skola;

class Program {
    static void Main() {

        // Course 1
        /* var course = new Course();

        course.CourseId = 1;
        course.Course = new Course {
            Title = "Svenska",
            Duration = "2 veckor",
            Start = DateTime.Today,
            End = DateTime.Today,
            Place = "Distans"
        }; */

        // JSon File Place
        var path = Environment.CurrentDirectory + "/Data/Courses.txt";

        // StreamWriter Class
        using StreamWriter write = new(path);
        var message = "+ Course created " + DateTime.Now;
        write.WriteLine(message);

        message = "+ Course created " + DateTime.Now;
        write.WriteLine(message);
        write.Close();

        using StreamReader read = new(path);
        var text = read.ReadToEnd();
        Console.WriteLine(text);
        read.Close();
       
    }
}
