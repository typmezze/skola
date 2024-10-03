namespace Skola.Models;

public class Teacher:Person {
    public string Area { get; set; }
    public string Courses { get; set; }

    public override string ToString() {
        return $"{FirstName}, {Area}, {Courses}";
    }
}