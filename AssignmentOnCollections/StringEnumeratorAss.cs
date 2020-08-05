using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AssignmentOnCollections
{
    class StringEnumeratorAss
    {
        static void Main()
        {
            StringCollection sc = new StringCollection();
            sc.Add("red");
            sc.Add("blue");
            sc.Add("green");
            sc.Add("yellow");
            sc.Add("brown");

            StringEnumerator en = sc.GetEnumerator();
            Console.WriteLine("---move next method---");

            while (en.MoveNext())
            {

                Console.WriteLine(en.Current);
            }
            en.Reset();

        }

    }
    }

