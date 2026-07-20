// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Marks a element for validation.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Struct)]
    public class ValidationCheckAttribute : Attribute
    {
    }

    /// <summary>
    /// implementation of validation
    /// </summary>
    public interface IValidationCheck
    {
        string? Validation { get; }
    }
}
