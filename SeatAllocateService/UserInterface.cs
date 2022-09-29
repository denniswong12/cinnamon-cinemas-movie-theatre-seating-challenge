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
            var numSeatsNeeded = rnd.Next(1, 4);
            NumSeatsNeeded = numSeatsNeeded;
            return numSeatsNeeded;
        }
    }
}

