﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            foreach (var character in input)
            {
                stack.Push(character);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
