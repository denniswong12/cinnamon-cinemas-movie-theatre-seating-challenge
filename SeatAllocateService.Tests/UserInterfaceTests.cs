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
        Console.SetIn(new StringReader("1"));
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
        Assert.That(output, Is.EqualTo("\nNot enough seats to allocate, remaining seat(s):\nC4\nC5\n"));
    }

    [Test]
    public void Passing_String_To_DisMessage_Should_Print_The_Input_String_To_Console()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        _userInterface.DisMessage("Testing Message");

        var output = stringWriter.ToString();
        Assert.That(output, Is.EqualTo("Testing Message\n"));
    }

    [Test]
    public void Ask_User_Name_Should_Return_Customers_Name()
    {
        Console.SetIn(new StringReader("Dennis"));
        var customerName = _userInterface.AskCustomerName();
        Assert.That(customerName, Is.EqualTo("Dennis"));
    }
}
