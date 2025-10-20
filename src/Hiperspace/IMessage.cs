namespace Hiperspace
{
    /// <summary>
    /// Messages are a special type that marshalls elements by value for transport over a network 
    /// between clients and servers, to provice appliction specific functionality that cabn include multiples
    /// parts
    /// </summary>
    public interface IMessage 
    {
        /// <summary>
        /// Bind this message and its cotents to the specified <see cref="SubSpace"/>, to allow navigation to other elements
        /// </summary>
        /// <param name="subSpace">current <see cref="SubSpace"/></param>
        /// <remarks>
        /// This does not bind the elements to the subspace cache - that needs to be done separately, if required`
        /// </remarks>
        void Bind(SubSpace subSpace);

        /// <summary>
        /// Unbinds the specified <see cref="SubSpace"/> from its current association.
        /// </summary>
        /// <remarks>This method removes the binding of the provided <see cref="SubSpace"/> object, 
        /// effectively disassociating it from its current context. Ensure that the  <paramref name="subSpace"/> is no
        /// longer needed in its bound state before calling this method.</remarks>
        /// <param name="subSpace">The <see cref="SubSpace"/> instance to unbind. Cannot be null.</param>
        void Unbind(SubSpace subSpace);

        /// <summary>
        /// Invoke the message to process its contents and return a response message
        /// </summary>
        /// <returns>a copy of this, mutated  to include value</returns>
        Task<IMessage> InvokeAsync(CancellationToken token = default);

        /// <summary>
        /// An async stream of messages, or the single value if it does not support streaming
        /// </summary>
        /// <returns>a stream of messages </returns>
        IAsyncEnumerable<IMessage> InvokeStreamAsync(CancellationToken token = default);

        /// <summary>
        /// Get the message as raw bytes for transport
        /// </summary>
        /// <param name="model">the type model used for proto encoding the message</param>
        /// <returns></returns>
        byte[] KeyBytes(BaseTypeModel model);

        /// <summary>
        /// Get the message as raw bytes for transport
        /// </summary>
        /// <param name="model">the type model used for proto encoding the message</param>
        /// <returns></returns>
        byte[] ValueBytes(BaseTypeModel model);

        /// <summary>
        /// Clone the current message with the value returned from an IO
        /// </summary>
        /// <typeparam name="TMessage">the concrete type of the message</typeparam>
        /// <param name="model">the type model used for proto encoding the message</param>
        /// <param name="value">the result of the IO</param>
        /// <returns>a copy of the current message, with value added</returns>
        TMessage WithValue<TMessage>(BaseTypeModel model, byte[] value) where TMessage : class, IMessage;
    }
}
