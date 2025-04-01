namespace TestNinja.Fundamentals
{
    public class FizzBuzz
    {
        public string GetOutput(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString(); 
        }

        /* Testcase 1: number is divisible by 3 and 5
         * Testcase 2: number is divisible by 3
         * Testcase 3: number is divisible by 5
         * Testcase 4: number is not divisible by 3 and by 5
         */
    }
}