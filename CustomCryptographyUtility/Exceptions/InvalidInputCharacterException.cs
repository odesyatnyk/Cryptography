using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCryptographyUtility.Exceptions
{

    [Serializable]
    public class InvalidInputCharacterException : Exception
    {
        public InvalidInputCharacterException() { }
        public InvalidInputCharacterException(string message) : base(message) { }
        public InvalidInputCharacterException(string message, Exception inner) : base(message, inner) { }
        protected InvalidInputCharacterException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
