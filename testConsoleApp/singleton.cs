using System;
using System.Collections.Generic;
using System.Text;

namespace testConsoleApp
{
    public class singletonEager
    {
        private static singletonEager singletonEagerobj = new singletonEager();
        private singletonEager() { }
        public static singletonEager getsingletonsobj {
            get
            {
                return singletonEagerobj;
            }
        }
    }

    public class singletonlazy
    {
        private static singletonlazy singletonlazyobj;
        private singletonlazy() { }

        private static object objectlock = new object();
        public static singletonlazy GetSingletonlazy
        {
            get
            {
                lock (objectlock)
                {
                    if (singletonlazyobj == null)
                        singletonlazyobj = new singletonlazy();
                    return singletonlazyobj;
                }
            }
        }
        public string username { get; set; }
    }
}
