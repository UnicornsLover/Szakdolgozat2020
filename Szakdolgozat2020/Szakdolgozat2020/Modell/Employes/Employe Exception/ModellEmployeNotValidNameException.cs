using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Employes
{
    [Serializable]
    internal class ModellEmployeNotValidNameException : Exception
    {
        public ModellEmployeNotValidNameException()
        {
        }

        public ModellEmployeNotValidNameException(string message) : base(message)
        {
        }

        public ModellEmployeNotValidNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellEmployeNotValidNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}