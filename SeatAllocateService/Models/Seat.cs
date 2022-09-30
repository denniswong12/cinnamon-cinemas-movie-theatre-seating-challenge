namespace SeatAllocateService
{
    public class Seat
    {
        private char _row;
        private int _col;
        private char _seatStatus;

        public Seat(char row, int col, char seatStatus)
        {
            _row = row;
            _col = col;
            _seatStatus = seatStatus;
        }

        public char RetrieveSeatStatus()
        {
            return _seatStatus;
        }

        public void UpdateSeatStatus(char seatStatus)
        {
            _seatStatus = seatStatus;
        }

        public string RetrieveRowCol()
        {
            return $"{_row}{_col}";
        }
    }
}

