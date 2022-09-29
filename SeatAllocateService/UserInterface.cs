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
            for (int i=0; i<seats.Count(); i++)
            {
                Console.WriteLine($"Remaining seats are: ");
                Console.WriteLine($"{seats[i].RetrieveRowCol()}");
            }
        }
    }
}

