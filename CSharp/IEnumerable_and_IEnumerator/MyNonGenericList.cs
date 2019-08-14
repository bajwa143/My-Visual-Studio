using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_and_IEnumerator
{
    // To create Enumerable collection we must implement IEnumerable interface
    class MyNonGenericList : IEnumerable
    {
        // both are static because we want these two to access in our inner class
        private static object[] _objects;
        private static int noOfObjects;

        // Constructor
        public MyNonGenericList(int noOfItems)
        {
            // creating object array
            noOfObjects = noOfItems;
            _objects = new object[noOfObjects];

            // Initializing our collection
            for (int i = 0; i < noOfObjects; i++)
            {
                _objects[i] = i*2;

            }
        }

        // We need to provide implementation of GetEnumerator() method of IEnumerable interface
        public IEnumerator GetEnumerator()
        {
            return new MyListEnumertor();
        }

        /*
         To implement IEnumerable/IEnumerable<T>, you must provide an enumerator.
         You can do this in one of three ways:
            • If the class is “wrapping” another collection, by returning the wrapped collection’s enumerator
            • Via an iterator using yield return
            • By instantiating your own IEnumerator/IEnumerator<T> implementation
         */
        // We are using last method to provide enumerator
        // So we need to implement IEnumerator interface
        private class MyListEnumertor : IEnumerator
        {
            /*
             The IEnumerator interface specifies the following property and methods:
                object Current { get; }
                bool MoveNext();
                void Reset();
            */

            private int _currentIndex = -1;

            // Current property return current Object
            public object Current
            {
                get
                {
                    return _objects[_currentIndex];
                }
            }

            // MoveNext pointer move the pointer to next item
            public bool MoveNext()
            {
                _currentIndex++;
                return (_currentIndex < noOfObjects);
            }

            // Reset method to return the pointer back to before the first item in the list
            public void Reset()
            {
                _currentIndex = -1;
            }
        }
    }
}
