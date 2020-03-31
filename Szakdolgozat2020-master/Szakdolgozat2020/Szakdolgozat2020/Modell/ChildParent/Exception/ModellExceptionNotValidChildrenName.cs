using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.ChildParent
{
    [Serializable]
    internal class ModellExceptionNotValidChildrenName : Exception
    {
        public ModellExceptionNotValidChildrenName()
        {
        }

        public ModellExceptionNotValidChildrenName(string message) : base(message)
        {
        }

        public ModellExceptionNotValidChildrenName(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellExceptionNotValidChildrenName(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}