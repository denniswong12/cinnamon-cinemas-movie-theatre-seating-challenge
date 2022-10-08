namespace SeatAllocateService
{
    public class Seat
    {
        private char _row;
        private int _col;
        private char _seatStatus;
        private string _customerName;

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

        public void UpdateSeatStatus(char seatStatus, string customerName)
        {
            _seatStatus = seatStatus;
            _customerName = customerName;
        }

        public string RetrieveRowCol()
        {
            return $"{_row}{_col}";
        }

        public void UpdateSeatCustomerName(string customerName)
        {
            _customerName = customerName;
        }

        public string RetrieveCustomerName()
        {
            return _customerName;
        }
    }
}

