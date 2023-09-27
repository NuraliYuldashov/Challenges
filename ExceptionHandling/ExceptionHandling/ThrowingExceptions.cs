using System;

namespace ExceptionHandling
{
    public static class ThrowingExceptions
    {
        public static void CheckParameterAndThrowException(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
        }

        public static void CheckBothParametersAndThrowException(object obj1, object obj2)
        {
            if (obj1 == null || obj2 == null)
            {
                throw new ArgumentNullException(obj1 == null ? nameof(obj1) : nameof(obj2));
            }
        }

        public static string CheckStringAndThrowException(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str;
        }

        public static string CheckBothStringsAndThrowException(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                throw new ArgumentNullException(string.IsNullOrEmpty(str1) ? nameof(str1) : nameof(str2));
            }

            return str1 + str2;
        }

        public static int CheckEvenNumberAndThrowException(int evenNumber, Exception argumentException)
        {
            if (evenNumber % 2 != 0)
            {
                throw argumentException;
            }

            return evenNumber;
        }

        public static int CheckCandidateAgeAndThrowException(int candidateAge, bool isCandidateWoman)
        {
            if ((!isCandidateWoman && (candidateAge < 16 || candidateAge > 63)) || (isCandidateWoman && (candidateAge < 16 || candidateAge > 58)))
            {
                throw new ArgumentOutOfRangeException(nameof(candidateAge));
            }

            return candidateAge;
        }

        public static string GenerateUserCode(int day, int month, string username)
        {
            if (day < 1 || day > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(day));
            }

            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month));
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username));
            }

            return $"{username}-{day}{month}";
        }
    }
}
