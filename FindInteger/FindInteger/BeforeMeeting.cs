using System;

namespace FindInteger
{
    public class BeforeMeeting
    {
        private int _counter { get; set; }
        private void Increase() => _counter++;

        public int Run(int[] givenList)
        {
            _counter = 0;
            var result = FindFirstPositiveInteger(givenList);
            Console.WriteLine(result != null ? $"Linear search: {result.Value}" : "Linear search: No result found");
            return _counter;
        }

        private int? FindFirstPositiveInteger(int[] givenArray)
        {
            for (var i = 1; i < givenArray.Length; i++)
            {
                Increase();
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
