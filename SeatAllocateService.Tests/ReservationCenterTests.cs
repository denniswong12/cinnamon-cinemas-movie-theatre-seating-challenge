namespace SeatAllocateService.Tests;

public class ReservationCenterTests
{
    private ReservationCenter _reservationCenter;

    [SetUp]
    public void Setup()
    {
        _reservationCenter = new ReservationCenter();
    }

    //Not able to test after changing _seats into private
    //[Test]
    //public void Call_InitHall_Should_Initialize_A_List_Of_Empty_Seats()
    //{
    //    _reservationCenter.InitHall();
    //    _reservationCenter._seats.Count().Should().Be(15);
    //}

    [Test]
    public void Get_Number_Of_Seats_Needed_Should_Return_Integer_Between_1_And_3()
    {
        Console.SetIn(new StringReader("2"));
        int numSeatsNeeded = _reservationCenter.GetNumOfSeatsNeeded();
        Assert.IsTrue(numSeatsNeeded.Equals(1) || numSeatsNeeded.Equals(2) || numSeatsNeeded.Equals(3));
    }

    [Test]
    public void Call_AllocateOneSeat_Should_Change_Seat_Status_To_Reserved()
    {
        Seat seat = new Seat('B', 3, 'A');
        _reservationCenter.AllocateOneSeat(seat, 'R', "Dennis");
        seat.RetrieveSeatStatus().Should().Be('R');
    }

    //[Test]
    //public void Call_AllocateAllSeat_Should_Change_Seats_Status_To_Reserved()
    //{
    //    _reservationCenter.InitHall();
    //    _reservationCenter.AllocateAllSeat();
    //    Assert.That(_reservationCenter.FindLastAllocatedSeat(), Is.GreaterThan(12));
    //}
}
