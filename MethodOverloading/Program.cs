namespace MethodOverloading
{
    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static double Add(double a, double b)
        { 
            return a + b; 
        }
        public static string Add(int m, int n, bool bill)
        {
            var sum = m + n;
            if (bill == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (bill == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else 
            {
                return $"{sum}";
            }
        }
        public static void Main(string[] args)
        {
            var x = 16;
            var y = 17;
                var answer = Add(x, y);

            var a = .0000001;
            var b = .0000002;
                var doubleAnswer = Add(a, b);

            var billAnswer = Add(1000000000, 3, true);

            Console.WriteLine($"int add: {answer}");
            Console.WriteLine($"decimal add: {doubleAnswer}");
            Console.WriteLine($"Your bill is {billAnswer}");
        }
    }
}
