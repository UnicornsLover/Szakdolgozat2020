using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Parents
{
    [Serializable]
    internal class MedellNotValidParentLoginPerException : Exception
    {
        public MedellNotValidParentLoginPerException()
        {
        }

        public MedellNotValidParentLoginPerException(string message) : base(message)
        {
        }

        public MedellNotValidParentLoginPerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MedellNotValidParentLoginPerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}