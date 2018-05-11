using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCryptographyUtility.Exceptions
{

    [Serializable]
    public class WrongKeyValueException : Exception
    {
        public WrongKeyValueException() { }
        public WrongKeyValueException(string message) : base(message) { }
        public WrongKeyValueException(string message, Exception inner) : base(message, inner) { }
        protected WrongKeyValueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
