using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Student : Person, ICanRead, ICanWrite
    {
        public string School { get; set; }

        public Student(string name)
            :base(name)
        {

        }

        public Student(string name, string school)
            :this(name)
        {
            School = school;
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}
