using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Employes
{
    [Serializable]
    internal class ModellEmployeNotValidMaidenNameException : Exception
    {
        public ModellEmployeNotValidMaidenNameException()
        {
        }

        public ModellEmployeNotValidMaidenNameException(string message) : base(message)
        {
        }

        public ModellEmployeNotValidMaidenNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellEmployeNotValidMaidenNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}