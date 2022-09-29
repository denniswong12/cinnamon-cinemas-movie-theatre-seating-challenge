namespace SeatAllocateService
{
    public class Seat
    {
        protected char Row;
        protected int Col;
        protected char SeatStatus;

        public Seat(char row, int col, char seatStatus)
        {
            Row = row;
            Col = col;
            SeatStatus = seatStatus;
        }

        public char RetrieveSeatStatus()
        {
            return SeatStatus;
        }
    }
}

