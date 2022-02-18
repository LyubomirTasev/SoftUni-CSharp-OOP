using System;
using System.Collections.Generic;

namespace CollectionHierarchie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] theFuckIsThisBs = Console.ReadLine().Split();

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            List<int> addResults = new List<int>();
            List<int> addRemoveResults = new List<int>();
            List<int> myListResults = new List<int>();

            foreach (var lilFuck in theFuckIsThisBs)
            {
                addResults.Add(addCollection.Add(lilFuck));
                addRemoveResults.Add(addRemoveCollection.Add(lilFuck));
                myListResults.Add(myList.Add(lilFuck));
            }

            int RemovedBullShit = int.Parse(Console.ReadLine());

            List<string> removedBullShitFromTheFuckingCollection = new List<string>();
            List<string> removedBullShitFromTheFuckingList = new List<string>();

            for (int i = 0; i < RemovedBullShit; i++)
            {
                removedBullShitFromTheFuckingCollection.Add(addRemoveCollection.Remove());
                removedBullShitFromTheFuckingList.Add(myList.Remove());
            }

            Console.WriteLine(string.Join(" ", addResults));
            Console.WriteLine(string.Join(" ", addRemoveResults));
            Console.WriteLine(string.Join(" ", myListResults));
            Console.WriteLine(string.Join(" ", removedBullShitFromTheFuckingCollection));
            Console.WriteLine(string.Join(" ", removedBullShitFromTheFuckingList));
        }
    }
}
