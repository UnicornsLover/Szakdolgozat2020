using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Event
{
    [Serializable]
    internal class ModellNotValidEventTitle : Exception
    {
        public ModellNotValidEventTitle()
        {
        }

        public ModellNotValidEventTitle(string message) : base(message)
        {
        }

        public ModellNotValidEventTitle(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidEventTitle(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}