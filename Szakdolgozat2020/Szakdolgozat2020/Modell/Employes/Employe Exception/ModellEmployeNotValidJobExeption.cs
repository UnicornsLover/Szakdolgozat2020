using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Employes
{
    [Serializable]
    internal class ModellEmployeNotValidJobExeption : Exception
    {
        public ModellEmployeNotValidJobExeption()
        {
        }

        public ModellEmployeNotValidJobExeption(string message) : base(message)
        {
        }

        public ModellEmployeNotValidJobExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellEmployeNotValidJobExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}