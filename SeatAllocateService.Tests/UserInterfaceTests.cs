namespace SeatAllocateService.Tests;

public class UserInterfaceTests
{
    private UserInterface _userInterface;

    [SetUp]
    public void Setup()
    {
        _userInterface = new UserInterface();
    }

    [Test]
    public void Calling_AskNumSeatsNeeded_Should_Return_An_Int_Between_1_And_3()
    {
        int numSeatNeeded = _userInterface.AskNumSeatsNeeded();
        Assert.IsTrue(numSeatNeeded.Equals(1) || numSeatNeeded.Equals(2) || numSeatNeeded.Equals(3));
    }
}
