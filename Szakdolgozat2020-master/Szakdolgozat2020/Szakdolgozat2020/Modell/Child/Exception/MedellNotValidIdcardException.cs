using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Children
{
    [Serializable]
    public class MedellNotValidChiIdcardException : Exception
    {
        public MedellNotValidChiIdcardException()
        {
        }

        public MedellNotValidChiIdcardException(string message) : base(message)
        {
        }

        public MedellNotValidChiIdcardException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MedellNotValidChiIdcardException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}