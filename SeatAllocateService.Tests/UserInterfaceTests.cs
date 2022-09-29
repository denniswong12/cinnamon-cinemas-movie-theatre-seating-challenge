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

    [Test]
    public void Given_Reaining_Seats_Info_Should_Display_On_Console()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        List<Seat> seats = new List<Seat>();
        seats.Add(new Seat('C',4,'A'));
        seats.Add(new Seat('C',5,'A'));
        _userInterface.DisEmptySeats(seats);

        var output = stringWriter.ToString();
        Assert.That(output, Is.EqualTo("Remaining seats are:\nC4\nC5\n"));
    }
}
