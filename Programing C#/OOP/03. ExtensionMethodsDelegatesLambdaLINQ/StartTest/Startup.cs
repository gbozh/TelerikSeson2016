﻿namespace StartTest
{
    using System;

    using DivisibleBySevenAndThree;
    using IEnumerable.Tests;
    using InfiniteConvergetSeries;
    using LongestString;
    using StringBuilder.Test;
    using Students.Tests;
    using TimerWithDelegate;
    using TimerWithEvent;

    public class Startup
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            StringbulderExtentionTest.Run();
            IEnumerableCalculationTest.Run();
            StudentArrayTest.Run();
            DivisableByTowNumbersTest.Run();
            TimerDelegateTest.Run();
            TimerWithEventTest.Run();
            StudentListTest.Run();
            LongestStringTest.Run();
            InfiniteConvergetSeriesTest.Run();
        }
    }
}
