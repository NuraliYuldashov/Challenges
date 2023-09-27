using System;

internal static class ThrowingExceptionsHelpers
{

    public static string CheckStringAndThrowException(string str)
    {
        // TODO #8. Replace the method code to throw an "ArgumentNullException" exception if the "str" parameter is null or equals to ""; otherwise return "str" value. Use string.IsNullOrEmpty method. Use "nameof" expression to get a parameter name for an exception constructor.
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentNullException(nameof(str));
        }

        return str;
    }
}
