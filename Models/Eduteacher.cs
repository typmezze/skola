namespace Skola.Models;

public class Eduteacher:Teacher {
    public string EmploymendDate { get; set; }

    public override string ToString() {
        return $"{FirstName}, {EmploymendDate}";
    }
}