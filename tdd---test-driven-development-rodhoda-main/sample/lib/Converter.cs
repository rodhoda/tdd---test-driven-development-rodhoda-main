using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace sample
    .lib
{
    static public class Converter
    {
       static public string IntegerToWordedString(int number) {

            if (number < 0) {
                throw new NotImplementedException();
            }
            
            string[] singles = {"zero","one", "two", "three", "four", "five", "six", "seven",
                                "eight", "nine"};
            string[] teens = {"ten", "eleven", "twelve", "thirteen", "fourten", "fifteen", 
                              "sixteen", "seventeen", "eighteen", "nineteen"};

            string[]  doubles = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty",
                                 "ninety",};

            // You can use the index of the list to directly find the worded string
            // of the integer
            if (number < 10 && number >= 0)
                return singles[number];

            // Same concept as above once you subtract by 10. 
            else if (number >= 10 && number < 20)
                return teens[number-10];
            
            else if (number >= 20 && number < 100) 
                return doubles[(number/10)-2] + "-" + IntegerToWordedString(number % 10);

            else if (number >= 100 && number <= 999) 
                return singles[number/100] + " hundred and " + IntegerToWordedString(number % 100);

            else
                return "zero";
       }  
    }
}