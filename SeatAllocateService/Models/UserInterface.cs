namespace SeatAllocateService
{
    public class UserInterface
    {
        private int _numSeatsNeeded;

        public UserInterface()
        {
        }

        public int AskNumSeatsNeeded()
        {
            //ask user to input no. of seats wanted and name
            Random rnd = new Random();
            _numSeatsNeeded = rnd.Next(1, 4);
            return _numSeatsNeeded;
        }

        public void DisEmptySeats(List<Seat> seats)
        {
            Console.WriteLine($"Not enough seats to allocate, remaining seat(s):");
            foreach (Seat seat in seats)
                Console.WriteLine($"{seat.RetrieveRowCol()}");
        }

        public void DisMessage(string disMsg)
        {
            Console.WriteLine(disMsg);
        }
    }
}

