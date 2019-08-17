using System.Collections;

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
                _objects[i] = i * 2;

            }
        }

        /*
                // We need to provide implementation of GetEnumerator() method of IEnumerable interface
                public IEnumerator GetEnumerator()
                {
                    return new MyListEnumertor();
                }
        */
        // C# 6 introduced expression-bodies members for member functions, and read-only properties
        public IEnumerator GetEnumerator() => new MyListEnumertor();

        /*
                // We can also 
                public IEnumerator GetEnumerator()
                {
                    foreach (var item in _objects)
                    {
                        yield return item;
                    }
                }
        */

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
                /*                get
                                {
                                    return _objects[_currentIndex];
                                }*/

                // C# 6 introduced expression-bodied members for member functions, and read-only properties. 
                // C# 7.0 expands the allowed members that can be implemented as expressions. 
                // In C# 7.0, you can implement constructors, finalizers, and get and set accessors on properties and indexers
                // So we can write above getter properties as
                get => _objects[_currentIndex];
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
