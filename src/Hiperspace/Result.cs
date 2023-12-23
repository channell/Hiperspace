// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    public static class Result
    {
        public enum Status { Ok, Skip, Fail }
        /// <summary>
        /// The result is ok
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">value</param>
        /// <returns>new result struct</returns>
        public static Result<T> Ok<T>(T result) => new Result<T>(result);
        /// <summary>
        /// The result was ok, but no action was performed
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">value</param>
        /// <returns>new result struct</returns>
        public static Result<T> Skip<T>(T result) => new Result<T>(result, Status.Skip);
        /// <summary>
        /// The result failed 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">value</param>
        /// <returns>new result struct</returns>
        public static Result<T> Fail<T>(T value, string? reason = null) => new Result<T>(value, Status.Fail, reason);
    }

    public struct Result<T>
    {
        public readonly Result.Status Status;
        private T? _value;
        public string? Reason;

        internal Result(T value, Result.Status status = Result.Status.Ok, string? reason = null)
        {
            _value = value;
            Reason = reason;
            Status = status;
        }

        public T Value 
        { 
            get 
            { 
                if (_value == null) throw new NullReferenceException(Reason); 
                return _value;
            }
        }

        public bool Ok => Status == Result.Status.Ok || Status == Result.Status.Skip;
        public bool New => Status == Result.Status.Ok;
        public bool Skip => Status == Result.Status.Skip || Status == Result.Status.Fail;
        public bool Fail => Status == Result.Status.Fail;

        public static explicit operator T (Result<T> value) 
        {
            return value.Value;
        }
    }
}
