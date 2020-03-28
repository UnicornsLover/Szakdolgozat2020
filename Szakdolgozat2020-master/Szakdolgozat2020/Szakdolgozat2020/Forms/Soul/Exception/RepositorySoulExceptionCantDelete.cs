using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Forms.Soul
{
    [Serializable]
    internal class RepositorySoulExceptionCantDelete : Exception
    {
        public RepositorySoulExceptionCantDelete()
        {
        }

        public RepositorySoulExceptionCantDelete(string message) : base(message)
        {
        }

        public RepositorySoulExceptionCantDelete(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySoulExceptionCantDelete(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}