using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.School
{
    [Serializable]
    internal class ModellNotValidSchoolLocationException : Exception
    {
        public ModellNotValidSchoolLocationException()
        {
        }

        public ModellNotValidSchoolLocationException(string message) : base(message)
        {
        }

        public ModellNotValidSchoolLocationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidSchoolLocationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}