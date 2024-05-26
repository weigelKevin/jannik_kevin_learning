using System;
using System.Collections;

namespace GlueckszahlBerechnen
{

    interface ITest
    {
        string DoSomethin();
    }
    interface ITest2
    {
        public void DoNothing();
    }

    class theClass : ITest,ITest2,ICloneable,IComparable,IEnumerable
    {
        public string DoSomethin()
        {
            throw new NotImplementedException();
        }

        public void DoNothing()
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    
    class Program
    {
        
        public static void Main(string[] args)
        {
        }
    }
}