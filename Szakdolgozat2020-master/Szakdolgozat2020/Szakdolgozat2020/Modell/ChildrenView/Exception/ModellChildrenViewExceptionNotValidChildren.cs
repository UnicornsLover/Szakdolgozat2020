using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    [Serializable]
    internal class ModellChildrenViewExceptionNotValidChildren : Exception
    {
        public ModellChildrenViewExceptionNotValidChildren()
        {
        }

        public ModellChildrenViewExceptionNotValidChildren(string message) : base(message)
        {
        }

        public ModellChildrenViewExceptionNotValidChildren(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildrenViewExceptionNotValidChildren(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}