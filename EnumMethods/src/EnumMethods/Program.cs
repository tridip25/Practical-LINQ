using System;

using System.Linq;
using System.Collections.Generic;

namespace EnumMethods
{
    public class Program
    {        
        static void Main(string[] args)
        {
               // var res= BuildIntegerSequence();
                //var res= RepeatedIntegerSequence();
                 var res= BuildStringSequence();
                foreach(var item in res)
                {
                    Console.WriteLine(item.ToString());
                }
         }

            public static IEnumerable<int> RepeatedIntegerSequence()
        {
            var integers = Enumerable.Repeat(-1,10);
            return integers;
        }
        public static IEnumerable<int> BuildIntegerSequence()
        {
            var integers = Enumerable.Range(0,10);
            return integers;
        }

         public static IEnumerable<char> BuildStringSequence()
        {
            var chr = Enumerable.Range(0,10).Select(i => (char) ('A'+ i));
            return chr;
        }


    
    }
}
