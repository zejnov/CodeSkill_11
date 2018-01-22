using System;

namespace FindInteger
{
    public class Program
    {
        public AfterMeeting IntSearcher = new AfterMeeting();

        public static void Main()
        {
            new Program().Execute();
        }

        private void Execute()
        {
            var givenList = new[] { -11, -2, 0, 0, 2 };

            var sth = IntSearcher.Run(givenList);

            Console.WriteLine(sth == null ? $"null" : $"{sth.Value}");
            Console.ReadLine();
        }
    }
}
