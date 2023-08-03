using System.Diagnostics;
namespace HW21
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 5; i <= 20; i *= 2)
            {
                FibonachiInvoke(i, FibonachiRecursion);
                FibonachiInvoke(i, FibonachiСyclical);
                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadLine();
        }
        static void FibonachiInvoke(int n, Func<int, int> func)
        {
            var sw = Stopwatch.StartNew();
            int result;
            sw.Start();
            result = func(n);
            sw.Stop();
            Console.WriteLine($"Для нахождения {n} члена последовательности Фибоначчи с помощью {func.Method.Name} " +
                $"понадобилось {sw.ElapsedTicks} тактов.");

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