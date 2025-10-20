// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    public interface IElement : IComparable
    {
        string SKey { get; set; }
        void Unbind(SubSpace subSpace);

        /// <summary>
        /// Cast the element to another view type using internal conversions 
        /// </summary>
        /// <typeparam name="TView"></typeparam>
        /// <returns>Teh Element as athe required type for null if it does not support it</returns>
        public abstract TView? Cast<TView>() where TView : class;
    }
}