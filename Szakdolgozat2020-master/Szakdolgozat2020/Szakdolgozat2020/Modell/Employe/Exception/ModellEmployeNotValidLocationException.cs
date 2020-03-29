using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Employes
{
    [Serializable]
    internal class ModellEmployeNotValidLocationException : Exception
    {
        public ModellEmployeNotValidLocationException()
        {
        }

        public ModellEmployeNotValidLocationException(string message) : base(message)
        {
        }

        public ModellEmployeNotValidLocationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellEmployeNotValidLocationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}