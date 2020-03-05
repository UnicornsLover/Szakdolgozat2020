using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Children
{
    [Serializable]
    internal class RepositoryChildExceptionCantAdd : Exception
    {
        public RepositoryChildExceptionCantAdd()
        {
        }

        public RepositoryChildExceptionCantAdd(string message) : base(message)
        {
        }

        public RepositoryChildExceptionCantAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryChildExceptionCantAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}