using System;

namespace FindInteger
{
    public class BeforeMeeting
    {
        public void Run(int[] givenList)
        {
            var result = FindFirstPositiveInteger(givenList);
            Console.WriteLine(result != null ? $"{result.Value}" : "No result found");
            Console.ReadKey();
        }

        private static int? FindFirstPositiveInteger(int[] givenArray)
        {
            for (var i = 1; i < givenArray.Length; i++)
            {
                var currentValue = givenArray[i];
                var previousValue = givenArray[i - 1];
                if (currentValue <= 0)
                    continue;

                if (currentValue - previousValue <= 1)
                    continue;

                if (previousValue >= 0)
                    return previousValue + 1;

                if (previousValue < 0 && currentValue >= 2)
                    return 1;
            }
            return null;
        }
    }
}
