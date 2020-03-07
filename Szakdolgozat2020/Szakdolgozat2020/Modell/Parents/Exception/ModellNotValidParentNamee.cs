using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Modell.Parents
{
    [Serializable]
    internal class ModellNotValidParentNamee : Exception
    {
        public ModellNotValidParentNamee()
        {
        }

        public ModellNotValidParentNamee(string message) : base(message)
        {
        }

        public ModellNotValidParentNamee(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellNotValidParentNamee(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}