using System;
using System.Collections;

namespace CSharp_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Start {nameof(CSharp_Hashtable)}");

            WorkWithHashtable1();

            WorkWithHashtable2();

            WorkWithHashtable3();

            WorkWithHashtable4();

            WorkWithHashtable5();
        }

        private static void WorkWithHashtable5()
        {
            //Keys property returns all the keys from a collection and the Value property returns all the values from a collection:
            Hashtable hashtableCollection = new Hashtable();

            hashtableCollection.Add(ElementNumber.First, 174);
            hashtableCollection.Add(ElementNumber.Second, "Test");
            hashtableCollection.Add(ElementNumber.Third, 10.30);

            var keys = hashtableCollection.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            var values = hashtableCollection.Values;
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }

        private static void WorkWithHashtable4()
        {
            Hashtable hashtableCollection = new Hashtable();

            hashtableCollection.Add(ElementNumber.First, 174);
            hashtableCollection.Add(ElementNumber.Second, "Test");
            hashtableCollection.Add(ElementNumber.Third, 10.30);

            hashtableCollection.Clear();

            Console.WriteLine(hashtableCollection.Count);

            Console.ReadKey();
        }

        private static void WorkWithHashtable3()
        {
            //ContainsKey  determines whether a collection contains a specific key:
            Hashtable hashtableCollection = new Hashtable();

            hashtableCollection.Add(ElementNumber.First, 174);
            hashtableCollection.Add(ElementNumber.Second, "Test");
            hashtableCollection.Add(ElementNumber.Third, 10.30);

            if (hashtableCollection.ContainsKey(ElementNumber.Second))
            {
                Console.WriteLine($"Collection contains key: {ElementNumber.Second} and its value is {hashtableCollection[ElementNumber.Second]}");
            }
            
            foreach (var item in hashtableCollection.Keys)
            {
                Console.WriteLine(hashtableCollection[item]);
            }

            Console.ReadKey();
        }

        private static void WorkWithHashtable2()
        {
            //The Remove method removes the element with the specified key from a collection:
            Hashtable hashtableCollection = new Hashtable();

            hashtableCollection.Add(ElementNumber.First, 174);
            hashtableCollection.Add(ElementNumber.Second, "Test");
            hashtableCollection.Add(ElementNumber.Third, 10.30);

            hashtableCollection.Remove(ElementNumber.Second);

            foreach (var item in hashtableCollection.Keys)
            {
                Console.WriteLine(hashtableCollection[item]);
            }

            Console.ReadKey();

        }

        private static void WorkWithHashtable1()
        {
            //The Add method adds an element with the specified key and value into the collection:
            Hashtable hashtableCollection = new Hashtable();

            hashtableCollection.Add(ElementNumber.First, 174);
            hashtableCollection.Add(ElementNumber.Second, "Test");
            hashtableCollection.Add(ElementNumber.Third, 10.30);

            foreach (var item in hashtableCollection.Keys)
            {
                Console.WriteLine(hashtableCollection[item]);
            }

            Console.ReadKey();
        }
    }
}
