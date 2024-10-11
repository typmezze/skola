namespace Skola.Models;

public class Teacher:Person {
    public string? Skills { get; set; }
    public string? Courses { get; set; }

    public override string ToString()
    {
        return $"{Id}, {FirstName}, {Skills}, {Courses}";
    }

}