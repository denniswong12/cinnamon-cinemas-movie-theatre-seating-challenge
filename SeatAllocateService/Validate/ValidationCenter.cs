using System;
namespace SeatAllocateService
{
    public class ValidationCenter
    {
        public ValidationCenter()
        {
        }

        public bool CheckUserInputNumber(string userInput, int startInt, int endInt)
        {
            return (int.TryParse(userInput, out int inNum) && inNum >= startInt && inNum <= endInt);
        }
    }
}

