namespace Skola.Models;

public class Course {
    public int CourseId { get; set; }
    public string Title { get; set; } = "";
    public string Duration { get; set; } = "";
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Place { get; set; } = "";

    public override string ToString() {
        return $"{CourseId}, {Title}, {Duration}, {Start}, {End}, {Place}";
    }

}