// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
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

        internal Result(T value, Result.Status status, string? reason, Exception? exception)
        {
            _value = value;
            Reason = reason;
            Status = status;
            _exception = exception;
        }

        public T Value 
        { 
            get 
            {
                if (_value is null)
                {
                    if (Exception is not null)
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
                if (_exception is not null)
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

        /// <summary>
        /// Helper function for chaining results together on success 
        /// </summary>
        /// <typeparam name="R">return type</typeparam>
        /// <param name="func">function to perform on the success value</param>
        /// <returns>result of the func</returns>
        public Result<R> Then<R>(Func<T, Result<R>> func)
        {
            switch (Status)
            {
                case Result.Status.Ok:
                case Result.Status.Skip:
                    return func(Value) switch
                    {
                        Result<R> r when r.Ok => r,
                        Result<R> r when r.Skip => Result.Skip(r.Value),
                        Result<R> r when r.Fail => Result.Fail(r.Value, r.Reason ?? Reason),
                        Result<R> r when r.Error => Result.Error<R>(r.Exception ?? Exception),
                        _ => Result.Fail<R>(default!, "Result created by reflection")
                    };

                case Result.Status.Fail when typeof(R) == typeof(T):
                case Result.Status.Error when typeof(R) == typeof(T):
                    return new Result<R>((R)(object)_value!, Status, Reason, _exception);

                case Result.Status.Fail:
                    return Result.Fail<R>(default!, Reason);

                case Result.Status.Error:
                    return Result.Error<R>(Exception);

                case Result.Status.EOF:
                    return Result.EOF<R>();

                default:
                    return Result.Fail<R>(default!, "Result created by reflection");
            }
        }

        /// <summary>
        /// Executes the specified action if the current result represents a failure or an error.
        /// </summary>
        /// <remarks>The action is invoked only when the result's status is either <see
        /// cref="Result.Status.Fail"/> or <see cref="Result.Status.Error"/>. For other statuses, the action is not
        /// executed.</remarks>
        /// <param name="func">The action to execute, which receives the current result as a parameter.</param>
        public void Else(Action<Result<T>> func)
        {
            switch (Status)
            {
                case Result.Status.Fail:
                case Result.Status.Error:
                    func(this);
                    break;
                default:
                    break;
            }
        }
    }
}
