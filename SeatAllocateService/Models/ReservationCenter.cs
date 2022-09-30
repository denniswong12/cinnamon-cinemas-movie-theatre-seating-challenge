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
            {1, 'R'}, //Reserved
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

        public void AllocateOneSeat(Seat seat, char seatStatus)
        {
            seat.UpdateSeatStatus(seatStatus);
        }

        public int FindLastAllocatedSeat()
        {
            int lastAllocatedSeat = 0;

            foreach (var seat in _seats)
                if (seat.RetrieveSeatStatus() == SeatStatus.ElementAt(1).Value)
                    lastAllocatedSeat++;

            return lastAllocatedSeat;
        }

        public void AllocateAllSeat()
        {
            int numSeatsNeeded = 0;
            int lastAllocatedSeat = FindLastAllocatedSeat();
            bool notEnoughEmptySeats = false;

            while (_seats[_seats.Count() - 1].RetrieveSeatStatus() == SeatStatus.ElementAt(0).Value)
            {
                numSeatsNeeded = GetNumOfSeatsNeeded();
                lastAllocatedSeat = FindLastAllocatedSeat();

                for (int i = lastAllocatedSeat; i < numSeatsNeeded + lastAllocatedSeat; i++)
                {
                    if (_seats.Count() - lastAllocatedSeat - numSeatsNeeded >= 0)
                        AllocateOneSeat(_seats[i], SeatStatus.ElementAt(1).Value);
                    else
                        notEnoughEmptySeats = true;
                }

                try
                {
                    if (notEnoughEmptySeats)
                    {
                        string remainingSeats = "Not enough seats to allocate, remaining seat(s):\n";

                        foreach (var seat in _seats)
                            if(seat.RetrieveSeatStatus() == SeatStatus.ElementAt(0).Value)
                                remainingSeats += $"{seat.RetrieveRowCol()}\n";

                        throw new NotEnoughEmptySeatException(remainingSeats);
                    }
                        
                }
                catch (NotEnoughEmptySeatException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
            if (!notEnoughEmptySeats)
                Console.WriteLine("All seats have been allocated.");
            else
            {
                string allocatedSeats = "Allocated seats are:\n";
                foreach (var seat in _seats)
                    if (seat.RetrieveSeatStatus() == SeatStatus.ElementAt(1).Value)
                        allocatedSeats += $"{seat.RetrieveRowCol()}\n";
                Console.WriteLine(allocatedSeats);
            }
        }
    }
}

