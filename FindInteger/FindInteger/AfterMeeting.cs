using System.Linq;

namespace FindInteger
{
    //input: oredered list of integeres, ASC & desc(later).

    class AfterMeeting
    {
        public void Run(int[] givenList)
        {

            FindInteger(givenList);
        }

        public int? FindInteger(int[] givenList)
        {
            var length = givenList.Length;

            //code goes there
            givenList.IsNegative();

            FindInteger(givenList);


            return null;
        }
    }

    public static class MyExtensions
    {
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
            return array.First() < 0 && array.Last() > 0;
        }

        public static bool HasSameValues(this int[] array)
        {
            return array.First() == array.Last();
        }

        public static bool HasValuesDifferentByOne(this int[] array)
        {
            return array.First() == array.Last() + 1;
        }

    }
}
