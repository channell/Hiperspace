namespace Hiperspace
{
    /// <summary>
    /// Element base classes are mutable to allow them to be used with Element Framework and initialiisers
    /// but are locked as soon as they are added to a hiperspace
    /// </summary>
    public class MutationException : Exception
    {
        public MutationException()  : base () { }
        public MutationException(string message) : base(message) { }
        public MutationException(string message, Exception inner) : base(message, inner) { }  
    }
}
