using System;
namespace myApp.Exceptions
{
    [Serializable]
    public class AdvancedOperationException : Exception
    {
        public AdvancedOperationException() { }

        public AdvancedOperationException(string message)
            : base(message) { }

        public AdvancedOperationException(string message, Exception inner)
            : base(message, inner) { }
    }
}
