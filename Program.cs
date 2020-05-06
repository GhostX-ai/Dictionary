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
    class MyDictionary<t, m>
    {
        t Key;
        m Value;
        MyDictionary<t, m>[] li;
        public MyDictionary()
        {
            li = new MyDictionary<t, m>[0];
        }
        public int Length
        {
            get
            {
                return li.Length;
            }
        }
        public void Add(t key, m val)
        {
            MyDictionary<t, m>[] newli = new MyDictionary<t, m>[li.Length + 1];
            for (int i = 0; i < li.Length; i++)
            {
                newli[i] = li[i];
            }
            newli[newli.Length - 1] = new MyDictionary<t, m>()
            {
                Key = key,
                Value = val
            };
            li = newli;
        }
        public MyDictionary<t, m> SelectByIndex(int index)
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
