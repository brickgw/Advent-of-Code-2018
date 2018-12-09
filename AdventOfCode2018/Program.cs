﻿using System;

namespace AdventOfCode2018
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specify day to get solution:");
            var day = Console.ReadLine();

            switch(day)
            {
                case "1":
                    var day1 = new Day1();
                    Console.WriteLine(day1.GetResults());
                    break;
                case "2":
                    var day2 = new Day2();
                    Console.WriteLine(day2.GetResults());
                    break;
                case "3":
                    var day3 = new Day3();
                    Console.WriteLine(day3.GetResults());
                    break;
                case "4":
                    var day4 = new Day4();
                    Console.WriteLine(day4.GetResults());
                    break;
                case "5":
                    var day5 = new Day5();
                    Console.WriteLine(day5.GetResults());
                    break;
                case "6":
                    var day6 = new Day6();
                    Console.WriteLine(day6.GetResults());
                    break;
                case "7":
                    var day7 = new Day7();
                    Console.WriteLine(day7.GetResults());
                    break;
                case "8":
                    var day8 = new Day8();
                    Console.WriteLine(day8.GetResults());
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;     
            }

            Console.ReadLine();
        }
    }
}
