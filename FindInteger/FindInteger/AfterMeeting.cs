using System;
using System.Linq;
// ReSharper disable PossibleLossOfFraction
//input: oredered list of integeres, ASC & desc(later).

namespace FindInteger
{
    public class AfterMeeting
    {
        public int? Run(int[] givenList)
        {
            return FindInteger(givenList);
        }

        public int? FindInteger(int[] givenList)
        {
            if (givenList.IsNegative() || givenList.HasSameValues() || givenList.HasValuesDifferentByOne())
                return null;

            if (givenList.IsTroughZero() && givenList.HasValuesDifferentByTwoOrMore() ||
                givenList.IsPositive() && givenList.HasValuesDifferentByTwoOrMore())
            {
                if (givenList.Length <= 3 && givenList[1] - givenList[0] > 1)
                {
                    if (givenList[0] > 0)
                        return givenList[0] + 1;

                    if (givenList[0] <= 0)
                        return 1;
                }

                return FindInteger(givenList.TakeLeftBunch()) ?? FindInteger(givenList.TakeRightBunch());
            }
            return null;
        }
    }

    public static class MyExtensions
    {
        public static int[] TakeRightBunch(this int[] array)
        {
            decimal value = array.Length / 2;
            var size = Math.Floor(value);
            return array.Skip((int)size).ToArray();
        }

        public static int[] TakeLeftBunch(this int[] array)
        {
            decimal value = array.Length / 2;
            var size = Math.Ceiling(value);
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
