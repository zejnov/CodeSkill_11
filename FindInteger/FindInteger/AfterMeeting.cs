using System;
using System.Linq;
// ReSharper disable PossibleLossOfFraction
//input: oredered list of integeres, ASC & desc(later).

namespace FindInteger
{
    public class AfterMeeting
    {
        private int _counter { get; set; }

        private void Increase()
        {
            _counter++;
            //Console.Write($" {_counter}");
        } 

        public Tuple<int,int> Run(int[] givenArray)
        {
            _counter = 0;
            var result = FindInteger(givenArray);
            Console.WriteLine(result != null ? $"Active search: {result.Value}" : "Active search: No result found");

            return new Tuple<int, int>(_counter, result.Value);
        }

        private int? FindInteger(int[] givenArray)
        {
            Increase();

            if (_counter > 1000)
            {
                givenArray.ToList().ForEach(a => Console.Write($"{a} "));
                Console.ReadKey();
            }

            if (givenArray.IsNegative() || givenArray.HasSameValues() || givenArray.HasValuesDifferentByOne())
                return null;

            if (givenArray.HasValuesDifferentByTwoOrMore() && (givenArray.IsTroughZero() || givenArray.IsPositive())) 
            {
                if (givenArray.Length < 3 && givenArray[1] - givenArray[0] > 1) ///sth there
                {
                    if (givenArray[0] > 0)
                        return givenArray[0] + 1;

                    if (givenArray[0] <= 0)
                        return 1;
                }

                return FindInteger(givenArray.TakeLeftBunch()) ?? FindInteger(givenArray.TakeRightBunch());
            }
            return null;
        }
    }

    public static class MyExtensions
    {
        public static int[] TakeRightBunch(this int[] array)
        {
            var value = array.Length / 2.0;
            var size = Math.Floor(value);
            return array.Skip((int)size).ToArray();
        }

        public static int[] TakeLeftBunch(this int[] array)
        {
            var value = array.Length / 2.0;
            var size = Math.Ceiling((decimal)value);
            return array.Take((int)size).ToArray();
        }

        public static bool IsNegative(this int[] array)
        {
            return array.First() < 0 && array.Last() < 0;
        }

        public static bool IsPositive(this int[] array)
        {
            return array.First() >= 0 && array.Last() > 0;
        }

        public static bool IsTroughZero(this int[] array)
        {
            return array.First() < 0 && array.Last() > 1;
        }

        public static bool HasSameValues(this int[] array)
        {
            return array.First() == array.Last();
        }

        public static bool HasValuesDifferentByOne(this int[] array)
        {
            return array.First() + 1 == array.Last();
        }

        public static bool HasValuesDifferentByTwoOrMore(this int[] array)
        {
            return array.First() + 2 <= array.Last();
        }
    }
}
