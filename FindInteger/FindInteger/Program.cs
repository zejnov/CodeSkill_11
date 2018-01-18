namespace FindInteger
{
    class Program
    {
        public static void Main()
        {
            var givenList = new[] { -11, -2, 1, 2, 7 };

            new BeforeMeeting().Run(givenList);

            new AfterMeeting().Run(givenList);

        }

        
    }
}
