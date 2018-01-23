using System;
using System.Linq;

namespace FindInteger
{
    public class Program
    {
        public AfterMeeting IntSearcher = new AfterMeeting();
        public BeforeMeeting IntSearcherLinear = new BeforeMeeting();

        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                new Program().Execute();
                Console.ReadKey(false);
            }
        }

        private void Execute()
        {
            var size = 1000;
            var array = GenerateRandomArray(size, 1000);

            var halfWay = IntSearcher.Run(array);
            var linear = IntSearcherLinear.Run(array);
            
            Console.WriteLine($"SUMMARY: Active search: {halfWay}, linear: {linear} in  range: {size}");

            foreach (var field in array)
            {
                Console.Write($" {field}");
            }
            Console.ReadLine();
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
