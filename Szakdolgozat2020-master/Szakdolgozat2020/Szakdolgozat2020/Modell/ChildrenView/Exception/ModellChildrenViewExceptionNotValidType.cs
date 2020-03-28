using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    [Serializable]
    internal class ModellChildrenViewExceptionNotValidType : Exception
    {
        public ModellChildrenViewExceptionNotValidType()
        {
        }

        public ModellChildrenViewExceptionNotValidType(string message) : base(message)
        {
        }

        public ModellChildrenViewExceptionNotValidType(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildrenViewExceptionNotValidType(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}