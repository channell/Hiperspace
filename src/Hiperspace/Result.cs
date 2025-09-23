// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    public static class Result
    {
        public enum Status { Ok, Skip, Fail, Error, EOF }
        /// <summary>
        /// The result is ok
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">value</param>
        /// <returns>new result struct</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static Result<T> Ok<T>(T result) => new Result<T>(result);
        /// <summary>
        /// The result was ok, but no action was performed
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">value</param>
        /// <returns>new result struct</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static Result<T> Skip<T>(T result) => new Result<T>(result, Status.Skip);
        /// <summary>
        /// The result failed 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">value</param>
        /// <returns>new result struct</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static Result<T> Fail<T>(T value, string? reason = null) => new Result<T>(value, Status.Fail, reason);
        /// <summary>
        /// The result failed due to an exception
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">value</param>
        /// <returns>new result struct</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static Result<T> Error<T>(Exception exception) => new Result<T>(exception);
        /// <summary>
        /// The result is EOF from a publisher/consumer channel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result">value</param>
        /// <returns>new result struct</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static Result<T> EOF<T>() => new Result<T>(default!, Status.EOF);
    }

    public struct Result<T>
    {
        public readonly Result.Status Status;
        private readonly T? _value;
        public readonly string? Reason;
        private readonly Exception? _exception;

        internal Result(T value, Result.Status status = Result.Status.Ok, string? reason = null)
        {
            _value = value;
            Reason = reason;
            Status = status;
        }
        internal Result(Exception? exception = null)
        {
            _exception = exception;
            Status = Result.Status.Error;   
        }

        public T Value 
        { 
            get 
            {
                if (_value == null)
                {
                    if (Exception != null)
                        throw Exception;
                    else
                        throw new NullReferenceException(Reason);
                }
                return _value;
            }
        }
        public Exception Exception
        {
            get
            {
                if (_exception != null)
                    return _exception;
                if (Status == Result.Status.Error)
                    return new Exception(Reason);
                return new NullReferenceException(Reason); 
            }
        }
        public bool Ok => Status == Result.Status.Ok || Status == Result.Status.Skip;
        public bool New => Status == Result.Status.Ok;
        public bool Skip => Status == Result.Status.Skip || Status == Result.Status.Fail;
        public bool Fail => Status == Result.Status.Fail || Status == Result.Status.Error;
        public bool Error => Status == Result.Status.Error;
        public bool EOF => Status == Result.Status.EOF;

        public static explicit operator T (Result<T> value) 
        {
            return value.Value;
        }
    }
}
