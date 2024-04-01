namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 40;
            var b = 35;
            var answer = Add(a, b);

            var x = 35.7m;
            var y = 56.3m;

            var decimalAnswer = Add(x, y);

            var Answer3 = Add(3, 18, true);

            Console.WriteLine($"integer Add: {answer} decimal Add: {decimalAnswer} \n" +
                $"{Answer3}");
        }
        public static int Add(int num1, int num2)
        {

            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
 
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool dollars)
          
        {
            var sum = num1 + num2;
            if (dollars == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (dollars == false && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return $"{sum} dollars";
            }
        }

    }
}
