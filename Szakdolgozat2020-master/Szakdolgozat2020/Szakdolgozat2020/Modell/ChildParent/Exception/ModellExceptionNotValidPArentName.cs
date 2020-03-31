using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.ChildParent
{
    [Serializable]
    internal class ModellExceptionNotValidPArentName : Exception
    {
        public ModellExceptionNotValidPArentName()
        {
        }

        public ModellExceptionNotValidPArentName(string message) : base(message)
        {
        }

        public ModellExceptionNotValidPArentName(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellExceptionNotValidPArentName(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}