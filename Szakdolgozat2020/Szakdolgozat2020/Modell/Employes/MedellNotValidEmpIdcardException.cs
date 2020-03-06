using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Employes
{
    [Serializable]
    internal class MedellNotValidEmpIdcardException : Exception
    {
        public MedellNotValidEmpIdcardException()
        {
        }

        public MedellNotValidEmpIdcardException(string message) : base(message)
        {
        }

        public MedellNotValidEmpIdcardException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MedellNotValidEmpIdcardException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}