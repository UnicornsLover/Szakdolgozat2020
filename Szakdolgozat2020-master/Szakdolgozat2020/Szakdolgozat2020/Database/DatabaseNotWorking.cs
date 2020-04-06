using System;
using System.Runtime.Serialization;

namespace Szakdolgozat2020.Database
{
    [Serializable]
    internal class DatabaseNotWorking : Exception
    {
        public DatabaseNotWorking()
        {
        }

        public DatabaseNotWorking(string message) : base(message)
        {
        }

        public DatabaseNotWorking(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DatabaseNotWorking(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}