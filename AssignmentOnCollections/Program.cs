using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace AssignmentOnCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            StringCollection str = new StringCollection();
            str.Add("Bringal");
            str.Add("Bottle_Gaurd");
            str.Add("Cauliflower");
            str.Add("Cabbage");
            str.Add("Okra");

            Console.WriteLine("The Elements of the StringCollection is---------");
            
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Copying the above StringCollection list to string array--------------");
            string[] str1 = new string[str.Count];
            str.CopyTo(str1, 0);

            Console.WriteLine("Printing the copied list into the array");
            foreach (var i in str)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Checking weather Tomato element is present in the StringCollection:{0}",
                str.Contains("Tomato"));

           
            Console.WriteLine("Checking the index of the element : {0} ", str.IndexOf("Cauliflower"));

            str.Insert(4, "Tomato");

            Console.WriteLine("Printing the list after inserting the new value");
            foreach (var item1 in str)
            {
                Console.WriteLine(item1);
            }

            str.Remove("Bringal");
            Console.WriteLine("List of the elements after removing----------");

            foreach (var item2 in str)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine("Removing element from the index value--------");
            str.RemoveAt(3);

            Console.WriteLine("Elements list after removing values from index 3");
            foreach (var item3 in str)
            {
                Console.WriteLine(item3);
            }

            Console.Read();
        }
    }
}

