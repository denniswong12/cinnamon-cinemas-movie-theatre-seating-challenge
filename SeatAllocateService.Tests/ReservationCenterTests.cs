namespace SeatAllocateService.Tests;

public class ReservationCenterTests
{
    private ReservationCenter _reservationCenter;

    [SetUp]
    public void Setup()
    {
        _reservationCenter = new ReservationCenter();
    }

    [Test]
    public void Call_InitHall_Should_Initialize_A_List_Of_Empty_Seats()
    {
        _reservationCenter.InitHall();
        _reservationCenter._seats.Count().Should().Be(15);
    }

    [Test]
    public void Get_Number_Of_Seats_Needed_Should_Return_Integer_Between_1_And_3()
    {
        int numSeatsNeeded = _reservationCenter.GetNumOfSeatsNeeded();
        Assert.IsTrue(numSeatsNeeded.Equals(1) || numSeatsNeeded.Equals(2) || numSeatsNeeded.Equals(3));
    }
}
