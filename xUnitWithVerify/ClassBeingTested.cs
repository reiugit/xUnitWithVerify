namespace xUnitWithVerify;

public record Person(string FirstName, string LastName, int Age);

internal static class ClassBeingTested
{
    public static Person GetJohnDoe()
        => new("John", "Doe", 36); // This is the demo-method we want to test
}
