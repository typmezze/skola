namespace Skola.Models;

public class CourseSpec {
    public string CourseId { get; set; } = "";
    public string Duration { get; set; } = "";
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Place { get; set; } = "";
}