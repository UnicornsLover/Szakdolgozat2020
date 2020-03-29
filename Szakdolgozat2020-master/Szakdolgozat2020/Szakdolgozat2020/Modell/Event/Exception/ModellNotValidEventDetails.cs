using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Event
{
    [Serializable]
    internal class ModellNotValidEventDetails : Exception
    {
        public ModellNotValidEventDetails()
        {
        }

        public ModellNotValidEventDetails(string message) : base(message)
        {
        }

        public ModellNotValidEventDetails(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidEventDetails(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}