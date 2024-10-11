namespace Skola.Models;

public class Course {
    public int CourseNumber { get; set; }
    public string Title { get; set; } = "";
    public Teacher? Teacher { get; set; }
    public CourseSpec? CourseSpec { get; set; }

    public override string ToString() {
        return $"{CourseNumber}, {Title}";
    }
}