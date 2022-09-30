namespace SeatAllocateService
{
    public class UserInterface
    {
        protected int NumSeatsNeeded { get; private set; }

        public UserInterface()
        {
        }

        public int AskNumSeatsNeeded()
        {
            Random rnd = new Random();
            NumSeatsNeeded = rnd.Next(1, 4);
            return NumSeatsNeeded;
        }

        public void DisEmptySeats(List<Seat> seats)
        {
            Console.WriteLine($"Remaining seats are:");
            foreach (Seat seat in seats)
                Console.WriteLine($"{seat.RetrieveRowCol()}");
        }

        public void DisMessage(string disMsg)
        {
            Console.WriteLine(disMsg);
        }
    }
}

