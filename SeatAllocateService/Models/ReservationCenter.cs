namespace SeatAllocateService
{
    public class ReservationCenter
    {
        private const int _maxCol = 5;
        private List<Seat> _seats = new List<Seat>();

        private static Dictionary<int, char> _seatStatus = new Dictionary<int, char>()
        {
            {0, 'A'}, //Available
            {1, 'R'}, //Reserved
            {2, 'B'} //Blocked
        };

        private static Dictionary<int, char> _rowIDs = new Dictionary<int, char>()
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
            foreach (var rowID in _rowIDs)
                for (int i=0; i<_maxCol; i++)
                    _seats.Add(new Seat(rowID.Value, i+1, _seatStatus.ElementAt(0).Value));
        }

        public int GetNumOfSeatsNeeded()
        {
            UserInterface userInterface = new UserInterface();
            return userInterface.AskNumSeatsNeeded();
        }

        public void AllocateOneSeat(Seat seat, char seatStatus)
        {
            seat.UpdateSeatStatus(seatStatus);
        }

        public int FindLastAllocatedSeat()
        {
            int lastAllocatedSeat = 0;

            foreach (var seat in _seats)
                if (seat.RetrieveSeatStatus() == _seatStatus.ElementAt(1).Value)
                    lastAllocatedSeat++;

            return lastAllocatedSeat;
        }

        public void AllocateAllSeat()
        {
            int numSeatsNeeded = 0;
            int lastAllocatedSeat = FindLastAllocatedSeat();
            bool notEnoughEmptySeats = false;
            UserInterface userInterface = new UserInterface();

            while (_seats[_seats.Count() - 1].RetrieveSeatStatus() == _seatStatus.ElementAt(0).Value)
            {
                numSeatsNeeded = GetNumOfSeatsNeeded();
                lastAllocatedSeat = FindLastAllocatedSeat();

                for (int i = lastAllocatedSeat; i < numSeatsNeeded + lastAllocatedSeat; i++)
                {
                    if (_seats.Count() - lastAllocatedSeat - numSeatsNeeded >= 0)
                        AllocateOneSeat(_seats[i], _seatStatus.ElementAt(1).Value);
                    else
                        notEnoughEmptySeats = true;
                }

                try
                {
                    if (notEnoughEmptySeats)
                        throw new NotEnoughEmptySeatException();
                }
                catch (NotEnoughEmptySeatException ex)
                {
                    List<Seat> remainingSeats = new List<Seat>();
                    foreach (var seat in _seats)
                        if (seat.RetrieveSeatStatus() == _seatStatus.ElementAt(0).Value)
                            remainingSeats.Add(seat);
                    userInterface.DisEmptySeats(remainingSeats);
                    break;
                }
            }

            if (!notEnoughEmptySeats)
            {
                userInterface.DisMessage("All seats have been allocated.");
            }
            else
            {
                string allocatedSeats = "Allocated seats are:\n";
                foreach (var seat in _seats)
                    if (seat.RetrieveSeatStatus() == _seatStatus.ElementAt(1).Value)
                        allocatedSeats += $"{seat.RetrieveRowCol()}\n";
                userInterface.DisMessage(allocatedSeats);
            }
        }
    }
}

