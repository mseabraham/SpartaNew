﻿using System;
using System.Text;

namespace ArraysAndStringsLib
{
    public class Exercises
    {
        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            string address = $"{number} {street}, {city} {postcode}.";
            return address;
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double percent = ((score / outOf) * 100);
            string output = $"You got {score} out of {outOf}: {percent}%";
            return output;
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            throw new NotImplementedException();
        }
        public static string ManipulateString(string input, int num)
        {
            throw new NotImplementedException();
        }
    }
}
