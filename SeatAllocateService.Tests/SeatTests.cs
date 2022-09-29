namespace SeatAllocateService.Tests;

public class SeatTestsReservationCenterTests
{
    private Seat _seat;

    [SetUp]
    public void Setup()
    {
        _seat = new Seat('A', 1, 'A');
    }

    [Test]
    public void Test1()
    {
        _seat.RetrieveSeatStatus().Should().Be('A');
    }

    [Test]
    public void Update_Seat_Status_To_Reserved_Should_Change_Status_To_Reserved()
    {
        _seat.UpdateSeatStatus('R');
        _seat.RetrieveSeatStatus().Should().Be('R');
    }
}
