using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Employes
{
    [Serializable]
    internal class ModellEmployeNotValidSexException : Exception
    {
        public ModellEmployeNotValidSexException()
        {
        }

        public ModellEmployeNotValidSexException(string message) : base(message)
        {
        }

        public ModellEmployeNotValidSexException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellEmployeNotValidSexException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}