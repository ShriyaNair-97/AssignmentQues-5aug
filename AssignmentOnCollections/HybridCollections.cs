using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnCollections
{
    class HybridCollections
    {
        static void Main()
        {
            HybridDictionary myDict = new HybridDictionary();

            myDict.Add("A", "Apple");
            myDict.Add("B", "Banana");
            myDict.Add("C", "Cat");
            myDict.Add("D", "Dog");
            myDict.Add("E", "Elephant");
            myDict.Add("F", "Fish");

            Console.WriteLine("Number of key/value pairs in myDict are :{0} ", myDict.Count);

            Console.WriteLine("copying the HybridDictionary entries to a Array index at the specified index ");
            DictionaryEntry[] myArr = new DictionaryEntry[myDict.Count];
            myDict.CopyTo(myArr, 0);

            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i].Key + " = " + myArr[i].Value);
            }
            myDict.Remove("D");
           
            Console.WriteLine("Number of key/value pairs in myDict are :{0}", myDict.Count);

            Console.WriteLine("Printing the valuesvafter removing the values ");
            IDictionaryEnumerator myEnumerator = myDict.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Console.WriteLine(myEnumerator.Key + " = " + myEnumerator.Value);
            }
            Console.WriteLine("To check whether the HybridDictionary contains 'G'");
            Console.WriteLine(myDict.Contains("G"));

            Console.WriteLine("To check whether the HybridDictionary contains 'B'"); 
            Console.WriteLine(myDict.Contains("B"));
            Console.WriteLine("To check whether the HybridDictionary is read-only.");
            Console.WriteLine(myDict.IsReadOnly);

            Console.WriteLine("To check whether the HybridDictionary is synchronized.");
            Console.WriteLine(myDict.IsSynchronized);

            //public HybridDictionary (bool caseInsensitive);
            //This is a constructor
            HybridDictionary myDict1 = new HybridDictionary(true);

            Console.WriteLine(" Adding key/value pairs in myDict ");
            myDict.Add("A", "Apple");
            myDict.Add("a", "Air");
            myDict.Add("B", "Banana");
            myDict.Add("C", "Cat");
            myDict.Add("D", "Dog");
            myDict.Add("d", "Dolphine");
            myDict.Add("E", "Elephant");
            myDict.Add("F", "Fish");
         
            Console.WriteLine("Displaying the key/value pairs in myDict");

            foreach (DictionaryEntry de in myDict1)
                Console.WriteLine(de.Key + " " + de.Value);

            HybridDictionary myDict2 = new HybridDictionary(true);

            Console.WriteLine(" Adding key/value pairs in myDict ");
            myDict.Add("A", "Apple");
            myDict.Add("a", "Air");
            myDict.Add("B", "Banana");
            myDict.Add("C", "Cat");
            myDict.Add("D", "Dog");
            myDict.Add("d", "Dolphine");
            myDict.Add("E", "Elephant");
            myDict.Add("F", "Fish");
            //This will throw an exception as the case of the keys are different 
            Console.WriteLine("Displaying the key/value pairs in myDict"); 

            foreach (DictionaryEntry de in myDict2)
                Console.WriteLine(de.Key + " " + de.Value);
            //HybridDictionary(Int32, Boolean) creates a HybridDictionary with the specified initial size and case sensitivity
            //public HybridDictionary (int initialSize, bool caseInsensitive);
            HybridDictionary myDict3 = new HybridDictionary(10, false);
            foreach (DictionaryEntry de in myDict3)
            { 
                Console.WriteLine(de.Key + " " + de.Value); 
            }
            //This will throw an exception

            HybridDictionary myDict4 = new HybridDictionary(10, true);
            foreach (DictionaryEntry de in myDict4)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
        }
    }
}
