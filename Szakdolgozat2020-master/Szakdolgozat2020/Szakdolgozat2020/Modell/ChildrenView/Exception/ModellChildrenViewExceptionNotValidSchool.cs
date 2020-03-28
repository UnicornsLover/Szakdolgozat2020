using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.SchoolChildren
{
    [Serializable]
    internal class ModellChildrenViewExceptionNotValidSchool : Exception
    {
        public ModellChildrenViewExceptionNotValidSchool()
        {
        }

        public ModellChildrenViewExceptionNotValidSchool(string message) : base(message)
        {
        }

        public ModellChildrenViewExceptionNotValidSchool(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellChildrenViewExceptionNotValidSchool(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}