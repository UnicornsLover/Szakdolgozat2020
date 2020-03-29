using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Employes
{
    [Serializable]
    internal class ModellEmployeNotValidBirthPlacesException : Exception
    {
        public ModellEmployeNotValidBirthPlacesException()
        {
        }

        public ModellEmployeNotValidBirthPlacesException(string message) : base(message)
        {
        }

        public ModellEmployeNotValidBirthPlacesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellEmployeNotValidBirthPlacesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}