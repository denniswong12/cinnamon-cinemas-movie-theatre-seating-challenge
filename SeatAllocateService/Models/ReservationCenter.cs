namespace SeatAllocateService
{
    public class ReservationCenter
    {
        private const int _maxRow = 3;
        private const int _maxCol = 5;
        public List<Seat> _seats = new List<Seat>();

        private static Dictionary<int, char> SeatStatus = new Dictionary<int, char>()
        {
            {0, 'A'}, //Available
            {1, 'V'}, //Reserved
            {2, 'B'} //Blocked
        };

        private static Dictionary<int, char> RowIDs = new Dictionary<int, char>()
        {
            {0, 'A'}, //First Row
            {1, 'B'}, //Second Row
            {2, 'C'} //Third Row
        };

        public ReservationCenter()
        {
        }

        public void InitHall()
        {
            foreach (var rowID in RowIDs)
                for (int i=0; i<_maxCol; i++)
                    _seats.Add(new Seat(rowID.Value, i+1, SeatStatus.ElementAt(0).Value));
        }

        public int GetNumOfSeatsNeeded()
        {
            UserInterface userInterface = new UserInterface();
            return userInterface.AskNumSeatsNeeded();
        }
    }
}

