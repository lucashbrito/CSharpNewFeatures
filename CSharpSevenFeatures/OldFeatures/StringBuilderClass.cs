using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSevenFeatures.OldFeatures
{
    public class StringBuilderClass
    {

        /*
         *A String is immutable, meaning String cannot be changed once created. For example, new string "Hello World!!" will occupy a memory space on the heap.
         * Now, by changing the initial string "Hello World!!" to "Hello World!! from Tutorials Teacher" will create a new string object on the memory heap
         * instead of modifying the initial string at the same memory address. This behaviour will hinder
         * the performance if the same string changes multiple times by replacing, appending, removing or inserting new strings in the initial string.
         *
         * To solve this problem, C# introduced StringBuilder.
         * StringBuilder is a dynamic object that allows you to expand the number of characters in the string.
         * It doesn't create a new object in the memory but dynamically expands memory to accommodate the modified string.
         */



        /*
         * StringBuilder is mutable.
         * StringBuilder performs faster than string when appending multiple string values.
         * Initialize StringBuilder as class
         * Use StringBuilder when you need to append more than three or four string.
         * Use append() method to add or append string with stringuilder.
         *  Use  tostring() method to get the string from stringbuilder. 
         */
    }
}
