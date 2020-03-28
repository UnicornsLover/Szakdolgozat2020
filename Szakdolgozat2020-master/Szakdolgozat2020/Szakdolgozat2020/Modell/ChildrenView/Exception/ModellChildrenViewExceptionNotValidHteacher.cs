using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    [Serializable]
    internal class ModellChildrenViewExceptionNotValidHteacher : Exception
    {
        public ModellChildrenViewExceptionNotValidHteacher()
        {
        }

        public ModellChildrenViewExceptionNotValidHteacher(string message) : base(message)
        {
        }

        public ModellChildrenViewExceptionNotValidHteacher(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildrenViewExceptionNotValidHteacher(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}