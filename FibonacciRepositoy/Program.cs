namespace FibonacciRepositoy
{
    internal class Program
    {
        static int Fib(int n)
        {
            if (n == 1)
                return 0;

            if (n == 2)
                return 1;

            int prev = 0;
            int curr = 1;
            for (int i = 3; i <= n; i++)
            {
                int next = prev + curr;
                prev = curr;
                curr = next;
            }
            return curr;

            static void Main(string[] args)
            {
                int n = 10;
                for (int i = 1; i <= n; i++)
                    Console.WriteLine(Fib(i));
            }
        }
    }
}
