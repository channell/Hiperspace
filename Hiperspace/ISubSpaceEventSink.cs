// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Interface for a space level event handler for Binding, Dependency and search events through a SubSpace
    /// </summary>
    /// <remarks>
    /// The interface primarily exists to support life-cycle events for GraphGPU cache
    /// </remarks>
    public interface ISubSpaceEventSink
    {
        /// <summary>
        /// Attempt to Bind the supplied SetSpace with the event sink provider 
        /// </summary>
        /// <remarks>
        /// Can be used by domain SubSpace to forward SetSpace events to the Event Sink at startup
        /// </remarks>
        /// <typeparam name="TEntity">The type of entity contained in the set space. Must inherit from Element<TEntity> and have a parameterless
        /// constructor.
        /// </typeparam>
        /// <param name="set">The set space to bind. Cannot be null.</param>
        /// <returns>true if the EventSink provides an implementation for this Event Type</returns>
        public bool BindSetSpace<TEntity>(SetSpace<TEntity> set) 
            where TEntity : Element<TEntity>, new();

        /// <summary>
        /// Handle the Event when an element is bound to the SetSpace
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity to be tracked.</typeparam>
        /// <param name="entity">The entity instance to attach to the context. Cannot be null.</param>
        public void Bound<TEntity>(TEntity entity) 
            where TEntity : Element<TEntity>, new();

        /// <summary>
        /// Handle a Dependency notification from a SetSpace
        /// </summary>
        /// <typeparam name="TEntity">The type of element to associate as the dependency target. Must inherit from Element<TEntity> and have a
        /// parameterless constructor.</typeparam>
        /// <param name="value">A tuple containing the target element and the dependency path from the sender. The target represents the
        /// dependent element, and the sender specifies the path through which the dependency is established.</param>
        public void Dependency<TEntity>((TEntity target, Meta.DependencyPath sender) value) 
            where TEntity : Element<TEntity>, new();
        
        /// <summary>
        /// Handle missing values in the SetSpace, e.g. by fetching from an alternate source
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity to mark as missing. Must inherit from Element<TEntity> and have a parameterless
        /// constructor.</typeparam>
        /// <param name="entity">The entity to be marked as missing. Cannot be null.</param>
        public void Missing<TEntity>(TEntity entity) 
            where TEntity : Element<TEntity>, new();

        /// <summary>
        /// Notification when a raw key/value is bound to Hiperspace
        /// </summary>
        /// <param name="key">serialised TVL (Tag, Value, Length) key value</param>
        /// <param name="value">serialised value</param>
        /// <param name="entity">optional source object that can be used directly if provided</param>
        public void Bound(byte[] key, byte[] value, object? entity);

        /// <summary>
        /// Performs custom processing or validation on the specified key before a get operation.
        /// </summary>
        /// <param name="key">A reference to the byte array representing the key to be processed. The value may be modified by this method
        /// and must not be null.</param>
        /// <remarks>Most usefull for telemetry services</remarks>
        public void BeforeGet(ref byte[] key);

        /// <summary>
        /// Value after get operation
        /// </summary>
        /// <param name="key">A reference to the byte array representing the key to be processed. The value may be modified by this method
        /// <param name="value">The result of the Get opportation</param>
        /// <remarks>Most usefull for telemetry services</remarks>
        public void AfterGet(ref byte[] key, ref byte[] value);

        /// <summary>
        /// Find requests to the underlying hiperspace
        /// </summary>
        /// <param name="begin">The TVL key being searched with lengths replace with 0x00</param>
        /// <param name="end">The TVL key being searched with lengths replace with 0xFF</param>
        /// <remarks>Most usefull for telemetry services</remarks>
        public void BeforeFind(ref byte[] begin, ref byte[] end);
        /// <summary>
        /// Notification after the Find requests to the underlying hiperspace
        /// </summary>
        /// <param name="begin">The TVL key being searched with lengths replace with 0x00</param>
        /// <param name="end">The TVL key being searched with lengths replace with 0xFF</param>
        /// <remarks>Most usefull for telemetry services</remarks>
        public void AfterFind(ref byte[] begin, ref byte[] end);
    }
}