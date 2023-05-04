using System;
using System.Collections.Generic;
using System.Text;

namespace testConsoleApp
{
    public abstract class AbstractClass_Info
    {
        
        static AbstractClass_Info()
        {
        }
        public AbstractClass_Info()
            {}
    }

    interface IClass_Info
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
