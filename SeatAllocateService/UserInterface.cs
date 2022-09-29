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
    }
}

