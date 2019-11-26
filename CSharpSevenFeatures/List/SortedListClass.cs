using System.Collections;


namespace CSharpSevenFeatures.List
{
    public class SortedListClass
    {
        //Add elements in SortedList
        //Use the Add() method to add key-value pairs into a SortedList.
        //Add() method signature: void Add(object key, object value)
        //Key cannot be null but value can be null. Also, datatype of all keys must be same, so that it can compare otherwise it will throw runtime exception.


        public void Initializer()
        {
            SortedList sortedList1 = new SortedList();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");

            SortedList sortedList2 = new SortedList();
            sortedList2.Add("one", 1);
            sortedList2.Add("two", 2);
            sortedList2.Add("three", 3);
            sortedList2.Add("four", 4);

            SortedList sortedList3 = new SortedList();
            sortedList3.Add(1.5, 100);
            sortedList3.Add(3.5, 200);
            sortedList3.Add(2.4, 300);
            sortedList3.Add(2.3, null);
            sortedList3.Add(1.1, null);

            //Remove elements from SortedList
            //Use the Remove() or RemoveAt() method to remove elements from a SortedList.

            //Remove() signature: void Remove(object key)
            //RemoveAt() signature: void RemoveAt(int index)

            sortedList3.Remove("one");//removes element whose key is 'one'
            sortedList3.RemoveAt(0);//removes element at zero index i.e first element: four
        }
    }
}
