namespace SeatAllocateService
{
    public class UserInterface
    {
        public UserInterface()
        {
        }

        public int AskNumSeatsNeeded()
        {
            var validationCenter = new ValidationCenter();
            string numSeatsNeeded = "";

            while (!validationCenter.CheckUserInputNumber(numSeatsNeeded, 1, 3))
            {
                Console.WriteLine("How many seats do you want to reserve? (1-3 seats)");
                numSeatsNeeded = Console.ReadLine();
            }
            return Int32.Parse(numSeatsNeeded);
        }

        public string AskCustomerName()
        {
            Console.WriteLine("May I know who is reserving the seat?");
            return Console.ReadLine();
        }

        public void DisEmptySeats(List<Seat> seats)
        {
            Console.WriteLine($"\nNot enough seats to allocate, remaining seat(s):");
            foreach (Seat seat in seats)
                Console.WriteLine($"{seat.RetrieveRowCol()}");
        }

        public void DisMessage(string disMsg)
        {
            Console.WriteLine(disMsg);
        }
    }
}