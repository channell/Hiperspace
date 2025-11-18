// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Indicates that the class includes an index by AsAt date for delta filtering
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DeltaIndexAttribute : Attribute
    {
        public DeltaIndexAttribute(int id) : base() { }
        public DeltaIndexAttribute() : base() { }
    }
    /// <summary>
    /// A SetSpace that has a delta index 
    /// template and a given point in time.
    /// </summary>
    /// <remarks>
    /// Used to retrieve changes since a delta datetime for Cube aggregation
    /// <typeparam name="TEntity">The type of the entity being compared and retrieved.</typeparam>
    public interface IDeltaIndex<TEntity>
    {
        /// <summary>
        /// Finds and returns a collection of entities that differ from the specified template,  based on changes
        /// occurring after the specified date and time.
        /// </summary>
        /// <param name="deltaFrom">The starting point in time from which changes are considered.</param>
        /// <param name="cache">A boolean value indicating whether to cache results
        /// <returns>An <see cref="IEnumerable{T}"/> containing entities that differ from the template  and have changes after
        /// the specified <paramref name="deltaFrom"/> date and time.</returns>
        public IEnumerable<TEntity> Delta(TEntity template, DateTime deltaFrom, bool cache = true);
    }
}
