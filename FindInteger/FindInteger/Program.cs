using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FindInteger
{
    public class Program
    {
        public AfterMeeting IntSearcher = new AfterMeeting();
        public BeforeMeeting IntSearcherLinear = new BeforeMeeting();

        private int[] Array { get; set; }

        public static void Main()
        {
            new Program().Run();
            Console.ReadKey();
        }

        private void Run()
        {

            //Execute(1);
            TestRun();

        }

        private void TestRun()
        {
            var size = 19;
            var array = GenerateRandomArray(size, 100);
            Console.WriteLine("Left: ");
            array.TakeLeftBunch().ToList().ForEach(a => Console.Write($"{a} "));
            Console.WriteLine("\nRight: ");
            array.TakeRightBunch().ToList().ForEach(a => Console.Write($"{a} "));
            Console.ReadKey();
        }

        private void Execute(int i)
        {
            var size = 100;
            Array = GenerateRandomArray(size, 100);

            var halfWay = IntSearcher.Run(Array);
            var linear = IntSearcherLinear.Run(Array);

            Console.WriteLine($"{i}. SUMMARY: Active search: {halfWay.Item1}, linear: {linear.Item1} in  range: {size}");
            
            if (halfWay.Item2 != linear.Item2)
            {
                Array.ToList().ForEach(a => Console.Write($"{a} "));
            }
        }

        private int[] GenerateRandomArray(int size, int range)
        {
            var array = new int[size];
            var random = new Random(DateTime.UtcNow.Millisecond);
            for (var i = 0; i < size; i++) 
            {
                array[i] = random.Next(-range, range);
            }
            return array.OrderBy(a => a).ToArray();
        }
    }
}
