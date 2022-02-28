using System;

namespace Model
{
    /// <summary>
    /// Class absence an object into collection
    /// </summary>
    public class ObjectNotFoundException : Exception
    {
        /// <summary>
        /// Exception of absence an object
        /// </summary>
        /// <param name="message">Exception message</param>
        public ObjectNotFoundException(string message) : base(message) { }
    }
}