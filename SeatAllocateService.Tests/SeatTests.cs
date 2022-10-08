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
    public void Call_RetrieveSeatStatus_Should_Return_Seats_Status()
    {
        _seat.RetrieveSeatStatus().Should().Be('A');
    }

    [Test]
    public void Update_Seat_Status_To_Reserved_Should_Change_Status_To_Reserved()
    {
        _seat.UpdateSeatStatus('R', "Dennis");
        _seat.RetrieveSeatStatus().Should().Be('R');
    }

    [Test]
    public void Call_RetrieveRowCol_Should_Return_Seats_Row_And_Col()
    {
        _seat.RetrieveRowCol().Should().Be("A1");
    }

    [Test]
    public void Call_UpdateSeatCustomerName_Should_Change_Customer_Name()
    {
        _seat.UpdateSeatCustomerName("Dennis");
        _seat.RetrieveCustomerName().Should().Be("Dennis");
    }
}
