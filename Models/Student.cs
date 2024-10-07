namespace Skola.Models;

public class Student:Person {
    public int Pnumber { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Grade { get; set; }

    public override string ToString() {
        return $"{FirstName}, {Pnumber}, {Address}, {PostalCode}, {City}, {Grade}";
    }
}