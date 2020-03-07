using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Parents
{
    [Serializable]
    internal class ModellNotValidParentName : Exception
    {
        public ModellNotValidParentName()
        {
        }

        public ModellNotValidParentName(string message) : base(message)
        {
        }

        public ModellNotValidParentName(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidParentName(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}