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
}
