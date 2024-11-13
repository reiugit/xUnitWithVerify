namespace xUnitWithVerify;

public class UnitTestWithVerify
{
    [Fact]
    public Task TestWithVerify()
    {
        var johnDoe = ClassBeingTested.GetJohnDoe();
        
        return Verify(johnDoe); // Verify is a method from Verify.Xunit
    }
}