using System;

namespace CustomRandomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("Gatti");
            list.Add("Poppa");
            list.Add("Shotta");
            list.Add("Vroy");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list.RandomString());
            }
        }
    }
}
