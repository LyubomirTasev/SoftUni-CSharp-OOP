using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string groupName)
        {
            Name = name;
            Age = age;
            GroupName = groupName;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string GroupName { get; set; }

        public int Food { get; private set; } = 0;

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
