using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Repository.Schools
{
    [Serializable]
    internal class RepositorySchoolExceptionCantAdd : Exception
    {
        public RepositorySchoolExceptionCantAdd()
        {
        }

        public RepositorySchoolExceptionCantAdd(string message) : base(message)
        {
        }

        public RepositorySchoolExceptionCantAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositorySchoolExceptionCantAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}