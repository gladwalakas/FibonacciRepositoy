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
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine($"Fib({n}) = {Fib(n)}");
        }
    }
}
