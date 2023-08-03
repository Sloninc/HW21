using System.Diagnostics;
namespace HW21
{
    internal class Program
    {
        static void Main()
        {
            var sw=Stopwatch.StartNew();
            Console.ReadLine();
        }

        static int FibonachiRecursion(int n)
        {
            if (n == 0 || n == 1) return n;

            return FibonachiRecursion(n - 1) + FibonachiRecursion(n - 2);
        }
        static int FibonachiСyclical(int n)
        {
            int result = 0;
            int prev = 1;
            int temp;

            for (int i = 0; i < n; i++)
            {
                temp = result;
                result = prev;
                prev += temp;
            }
            return result;
        }
    }
}