using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Parents
{
    [Serializable]
    internal class MedellNotValidParentIdcardException : Exception
    {
        public MedellNotValidParentIdcardException()
        {
        }

        public MedellNotValidParentIdcardException(string message) : base(message)
        {
        }

        public MedellNotValidParentIdcardException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MedellNotValidParentIdcardException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}