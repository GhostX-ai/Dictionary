using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
    class MyList<t>
    {
        t[] li;
        public int Length
        {
            get
            {
                return li.Length;
            }
        }
        public MyList()
        {
            li = new t[0];
        }
        public void Add(t val)
        {
            t[] newli = new t[li.Length + 1];
            for (int i = 0; i < li.Length; i++)
            {
                newli[i] = li[i];
            }
            newli[newli.Length - 1] = val;
            li = newli;
        }
        public t SelectByIndex(int index)
        {
            return li[index];
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < li.Length; i++)
            {
                yield return li[i];
            }
            yield break;
        }
    }
}
