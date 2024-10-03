namespace Skola.Models;

public class Person {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Phone { get; set; }
    public string Email { get; set; }

    public override string ToString() {
        return $"{Id}, {FirstName}, {LastName}, {Phone}, {Email}";
    }
}