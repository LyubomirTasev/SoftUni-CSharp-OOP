using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : IBirthable
    {
        public Pet(string birthday, string name)
        {
            Birthday = birthday;
            Name = name;
        }

        public string Birthday { get; set; }
        public string Name { get; set; }
    }
}
