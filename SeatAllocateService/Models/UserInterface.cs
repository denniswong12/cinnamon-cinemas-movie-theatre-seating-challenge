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
            Console.WriteLine("How many seats do you want to reserve? (1-3 seats)");
            var _numSeatsNeeded = Console.ReadLine();
            return Int32.Parse(_numSeatsNeeded);
        }

        public string AskCustomerName()
        {
            Console.WriteLine("May I know who is reserving the seat?");
            return Console.ReadLine();
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