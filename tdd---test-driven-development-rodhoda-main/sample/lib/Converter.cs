using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample
    .lib
{
    static public class Converter
    {
       static public string IntegerToWordedString(int number) {

            string[] singles = {"zero","one", "two", "three", "four", "five", "six", "seven",
                                "eight", "nine"};
            if (number < 10)
                return singles[number];
            else
                return "zero";
       }  
    }
}