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
}
