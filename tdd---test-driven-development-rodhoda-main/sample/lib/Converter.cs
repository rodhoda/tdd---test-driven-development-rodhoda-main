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
            if (number == 0) 
                return "zero";
            if (number == 1) 
                return "one";
            else return "none";
       }  
    }
}