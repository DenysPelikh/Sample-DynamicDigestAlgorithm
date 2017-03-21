using System;

namespace Algorithm.Core
{
    public class AlgorithmResult
    {
        public bool IsSuccess { get; }
        public string ErrorMessage { get; }

        protected AlgorithmResult()
        {
            IsSuccess = true;
            ErrorMessage = string.Empty;
        }

        protected AlgorithmResult(string errorMessage)
        {
            IsSuccess = false;
            ErrorMessage = errorMessage;
        }

        public static AlgorithmResult Success()
        {
            return new AlgorithmResult();
        }

        public static AlgorithmResult Fail(string errorMessage)
        {
            return new AlgorithmResult(errorMessage);
        }
    }

    public class AlgorithmResult<T> : AlgorithmResult
    {
        public T Value { get; }

        protected AlgorithmResult(T value) 
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            Value = value;
        }

        protected AlgorithmResult(T value, string errorMessage)
            : base(errorMessage)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            Value = value;
        }

        public static AlgorithmResult<T> Success(T value)
        {
            return new AlgorithmResult<T>(value);
        }

        public static AlgorithmResult<T> Fail(T value, string errorMessage)
        {
            return new AlgorithmResult<T>(value, errorMessage);
        }
    }
}
