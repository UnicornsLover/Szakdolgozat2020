using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.EventChildren
{
    [Serializable]
    internal class ModellNotValidExceptionChildrenName : Exception
    {
        public ModellNotValidExceptionChildrenName()
        {
        }

        public ModellNotValidExceptionChildrenName(string message) : base(message)
        {
        }

        public ModellNotValidExceptionChildrenName(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidExceptionChildrenName(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}