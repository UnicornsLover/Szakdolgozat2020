using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020
{
    [Serializable]
    internal class RepositorySoulExceptionCantAdd : Exception
    {
        public RepositorySoulExceptionCantAdd()
        {
        }

        public RepositorySoulExceptionCantAdd(string message) : base(message)
        {
        }

        public RepositorySoulExceptionCantAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySoulExceptionCantAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}