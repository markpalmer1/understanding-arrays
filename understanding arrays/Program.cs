﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[6];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            numbers[5] = 45;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
           

            //int[] numbers = new int[] { 4, 8, 15, 17, 23, 45, };

            
            string[] names = new string[] { "Eddie", "Alex", "Jon", "Mark" };
            
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            
            foreach (string name in names);
        
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            
                string zig = "You can do what you want if you try super dooper hard";

                char[] charArray = zig.ToCharArray();
                Array.Reverse(charArray);

                foreach (char zigChar in charArray)
                {
                    Console.Write(zigChar);
                }
                Console.ReadLine();
            
            }
        }
    }
}
