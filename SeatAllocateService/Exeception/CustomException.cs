using System;
namespace SeatAllocateService
{
    [Serializable]
    public class NotEnoughEmptySeatException : Exception
    {
        public NotEnoughEmptySeatException()
        { }

        public NotEnoughEmptySeatException(string message)
            : base(message)
        { }
    }
}