using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSevenFeatures.List
{
    public class ArrayListClass
    {
        //C# - ArrayList
        //ArrayList is a non-generic type of collection in C#. It can contain elements of any data types.
        //It is similar to an array, except that it grows automatically as you add items in it. Unlike an array, you don't need to specify the size of ArrayList.

        //the ArrayList class implements IEnumerable, ICollection, and IList interfaces.
        //So, you can create an object of ArrayList class and assign it to the variable of any base interface type.
        //However, if you assign it to IEnumerable or ICollection type variable then you won't be able to add elements and access ArrayList by index.
        public void Example()
        {
            ArrayList myArryList1 = new ArrayList();// Recommended
            // or - with some limitations
            IList myArryList2 = new ArrayList();
            // or - with some limitations
            ICollection myArryList3 = new ArrayList();
            // or - with some limitations
            IEnumerable myArryList4 = new ArrayList();

            myArryList1.Add(1);
            myArryList1.Add("Two");
            myArryList1.Add(3);
            myArryList1.Add(4.5);

            IList arryList2 = new ArrayList()
            {
                100, 200
            };

            //Adding entire collection using ArrayList.AdRange() method.
            ////Note: IList does not contain AddRange() method.
            myArryList1.AddRange(arryList2);

            foreach (var obj in myArryList1)
            {
                Console.WriteLine(obj);
            }

            //Use the ArrayList.InsertRange()
            //method to insert all the values from another collection into ArrayList at the specfied index.
            myArryList1.InsertRange(2, myArryList1);

            //Use the IList.RemoveAt() method to remove an element from the specified index location.
            myArryList1.RemoveAt(1); //Removes the first element from an ArrayList

            //Use the ArrayList.RemoveRange() method to remove multiple elements from the specified index till the specified number of elements in the ArrayList.
            //Please note that the RemoveRange() method only available in the ArrayList class but not in IList.So, it can only be use with the variable of type ArrayList.
            myArryList1.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

            //ArrayList Sorting
            //The ArrayList class includes Sort() and Reverse() method.The Sort() method arranges elements in ascending order.
            //However, all the elements should have same data type so that it can compare with default comparer otherwise it will throw runtime exception.
            //The Reverse() method arranges elements in reverse order. Last element at zero index and so on.


            //ArrayList can store items(elements) of any datatype.
            //ArrayList resizes automatically as you add the elements.
            //ArrayList values must be cast to appropriate data types before using it.
            //ArrayList can contain multiple null and duplicate items.
            //ArrayList can be accessed using foreach or for loop or indexer.
            //Use Add(), AddRange(), Remove(), RemoveRange(), Insert(), InsertRange(), Sort(), Reverse() methods.


        }
    }
}
