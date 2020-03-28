using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.School
{
    [Serializable]
    internal class ModellNotValidSchoolNameException : Exception
    {
        public ModellNotValidSchoolNameException()
        {
        }

        public ModellNotValidSchoolNameException(string message) : base(message)
        {
        }

        public ModellNotValidSchoolNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidSchoolNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}