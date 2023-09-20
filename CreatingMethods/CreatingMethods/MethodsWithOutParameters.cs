using System;

namespace CreatingMethods
{
    public static class MethodsWithOutParameters
    {   


        public static void ReturnValues(out bool trueValue, out bool falseValue)
        {
            trueValue = true;
            falseValue = false;
        }

        
        // TODO #13. Add a static method here with name "ReturnValues" that gets "lowerCaseA" and "upperCaseA" parameters ("char" type) with out parameter modifier. The method should return 'a' and 'A' values.
        //char lowerCaseA;
        //char upperCaseA;
        public static void ReturnValues(out char lowerCaseA, out char upperCaseA)
        {
            Console.WriteLine(lowerCaseA); // Prints "a"
            Console.WriteLine(upperCaseA); // Prints "A"
        }



        // TODO #14. Add a static method here with name "ReturnValues" that gets "minFloatValue" and "maxFloatValue" parameters ("float" type) with out parameter modifier. The method should return float min and max values.
        //float minFloatValue;
        //float maxFloatValue;
        public static void ReturnValues(out float minFloatValue, out float maxFloatValue)
        {
            if (minFloatValue > maxFloatValue )
            {
                minFloatValue += maxFloatValue
                maxFloatValue = minFloatValue - maxFloatValue;
                minFloatValue = minFloatValue - maxFloatValue;

            }
            Console.WriteLine(minFloatValue);
            Console.WriteLine(maxFloatValue);
        }
        // TODO #15. Add a static method here with name "ReturnValues" that gets "minIntValue" and "maxIntValue" parameters ("int" type) with out parameter modifier. The method should return int min and max values.
        //int minIntValue;
        //int maxIntValue;
        public static void ReturnValues(out int minIntValue, out int maxIntValue)
        {
            if (minIntValue > maxIntValue)
            {
                minIntValue += maxIntValue
                maxIntValue = minIntValue - maxIntValue;
                minIntValue = minIntValue - maxIntValue;

            }
            Console.WriteLine(minIntValue);
            Console.WriteLine(maxIntValue);
        }


        // TODO #16. Add a static method here with name "ReturnValues" that gets "minLongValue" and "maxLongValue" parameters ("long" type) with out parameter modifier. The method should return long min and max values.
        //int minLongValue;
        //int maxLongValue;
        public static void ReturnValues(out long minLongValue, out long maxLongValue)
        {
            if (minLongValue > maxLongValue)
            {
                minLongValue += maxLongValue
                maxLongValue = minLongValue - maxLongValue;
                minLongValue = minLongValue - maxLongValue;

            }
            Console.WriteLine(minLongValue);
            Console.WriteLine(maxLongValue);
        }
    }
}
