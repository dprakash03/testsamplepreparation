using System;
using System.Collections.Generic;
using System.Text;

namespace testConsoleApp
{
    public class parenttest
    {
        public string print()
        {
            return "parenttest";
        }
    }

    public class childtest : parenttest
    {
        public new string print()
        {
            return "childtest";
        }
    }

    class Class1
    {
        public virtual void show()
        {
            Console.WriteLine("Super class show method");
        }
    }
    class Class2 : Class1
    {
        public override void show()
        {
            Console.WriteLine("Sub class override show method");
        }
    }
}
