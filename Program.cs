using System.Data.SqlTypes;
using System.Text.Encodings.Web;
using System.Text.Json;
using Skola.Models;

namespace Skola;

class Program {
    static void Main() {

        // Course 1
        var course = new Course();
        course.CourseId = 1;
        course.Title = "Svenska";
        course.Teacher = new Teacher {
            FirstName = "Janne",
            LastName = "Hansson",
            Email = "janne@gmail.se",
            Id = 1,
            Skills = "C#, Javascript, HTML, CSS, JS,",
            Courses = "Svenska"
        };
        course.CourseSpec = new CourseSpec {
            CourseNumber = "Sv24-00-00",
            Duration = "2 veckor",
            Start = DateTime.Today,
            End = DateTime.Today,
            Place = "Distans"
        };





        var options = new JsonSerializerOptions() {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        // Write JSon File
        var path = string.Concat(Environment.CurrentDirectory, "/Data/Courses.json");
        var json = JsonSerializer.Serialize(course, options);
        File.WriteAllText(path, json);
        // Read Json File
        var savedJson = File.ReadAllText(path);
        

        options = new JsonSerializerOptions() {
            PropertyNameCaseInsensitive = true
        };
        var xcourse = JsonSerializer.Deserialize<Course>(savedJson);
        Console.WriteLine(xcourse);
    }
}
