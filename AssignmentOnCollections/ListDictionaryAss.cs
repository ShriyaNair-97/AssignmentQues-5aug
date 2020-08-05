using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnCollections
{
    class ListDictionaryAss
    {
        static void Main()
        {
            ListDictionary listDictionary = new ListDictionary();
            listDictionary.Add(1, "Asia");
            listDictionary.Add(2, "Australia");
            listDictionary.Add(3, "Africa");
            listDictionary.Add(4, "America");
            listDictionary.Add(5, "Antartica");



            Console.WriteLine("Printing the elements");
            foreach (DictionaryEntry entry in listDictionary)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }



            bool ld = listDictionary.Contains(8);
            Console.WriteLine("Contains the key 8 in the list or not:{0}", ld);



            Console.WriteLine("Printing the element list using GetEnumerator method-----");

            IDictionaryEnumerator ide = listDictionary.GetEnumerator();

            DictionaryEntry de;
            while (ide.MoveNext())
            {
                de = (DictionaryEntry)ide.Current;
                Console.WriteLine("{0} = {1}", de.Key, de.Value);
            }



            DictionaryEntry[] arr = new DictionaryEntry[listDictionary.Count];
            listDictionary.CopyTo(arr, 0);
            Console.WriteLine("Printing the Copied Array");
            foreach (var arr1 in arr)
            {
                Console.WriteLine("{0}-->{1}", arr1.Key, arr1.Value);
            }
            listDictionary.Remove(4);
            Console.WriteLine("List Printing after removing the element from the index 4");
            foreach (DictionaryEntry item2 in listDictionary)
            {
                Console.WriteLine("{0} --> {1}", item2.Key, item2.Value);
            }
        }
    }
}
