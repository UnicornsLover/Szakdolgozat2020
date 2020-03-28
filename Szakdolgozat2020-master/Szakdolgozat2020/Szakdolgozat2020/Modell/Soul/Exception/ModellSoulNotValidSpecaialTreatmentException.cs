using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Soul
{
    [Serializable]
    internal class ModellSoulNotValidSpecaialTreatmentException : Exception
    {
        public ModellSoulNotValidSpecaialTreatmentException()
        {
        }

        public ModellSoulNotValidSpecaialTreatmentException(string message) : base(message)
        {
        }

        public ModellSoulNotValidSpecaialTreatmentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellSoulNotValidSpecaialTreatmentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}