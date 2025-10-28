using System.Runtime.Serialization;

namespace PracticeExercise3
{
    [Serializable]
    public class EmptyQueueException : Exception
    {
        public EmptyQueueException()
        {
        }

        public EmptyQueueException(string? message) : base(message)
        {
        }

        public EmptyQueueException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmptyQueueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}