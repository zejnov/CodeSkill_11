using System;

namespace FindInteger
{
    class Program
    {
        public static void Main()
        {
            var givenList = new[] { -11, -2, 0,0, 2 };

            //new BeforeMeeting().Run(givenList);

            var sth = new AfterMeeting().Run(givenList);
            Console.WriteLine(sth == null ? $"null" : $"{sth.Value}");
            Console.ReadLine();
        }

        
    }
}
