using System;
using System.Runtime.Serialization;

namespace Yarm.ConsoleApp
{
    /// <summary>
    /// This represents the exception entity when input path is null.
    /// </summary>
    public class NullInputPathException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullInputPathException"/> class.
        /// </summary>
        public NullInputPathException() : this("Input path is null or white-space")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullInputPathException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public NullInputPathException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullInputPathException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner <see cref="Exception"/> instance.</param>
        public NullInputPathException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullInputPathException"/> class.
        /// </summary>
        /// <param name="info"><see cref="SerializationInfo"/> instance.</param>
        /// <param name="context"><see cref="StreamingContext"/> instance.</param>
        protected NullInputPathException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}