namespace Skola.Models;

public class Admin:Eduteacher {

    public override string ToString()
    {
        return $"{Id}, {FirstName}, {EmploymendDate}";
    }
}