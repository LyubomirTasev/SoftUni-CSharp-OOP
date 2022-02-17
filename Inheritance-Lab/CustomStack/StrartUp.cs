using System;
using System.Collections.Generic;

namespace CustomStack
{
    class StrartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            stack.AddRange(new List<string>()
            {
                "123",
                "456",
                "789",
                "Gogi"
            });

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
