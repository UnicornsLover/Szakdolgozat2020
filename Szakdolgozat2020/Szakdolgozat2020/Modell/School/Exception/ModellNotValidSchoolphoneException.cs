using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.School
{
    [Serializable]
    internal class ModellNotValidSchoolphoneException : Exception
    {
        public ModellNotValidSchoolphoneException()
        {
        }

        public ModellNotValidSchoolphoneException(string message) : base(message)
        {
        }

        public ModellNotValidSchoolphoneException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidSchoolphoneException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}