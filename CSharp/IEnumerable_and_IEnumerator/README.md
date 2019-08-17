## IEnumerable and IEnumerator

The IEnumerator interface defines the basic low-level protocol by which elements
in a collection are traversed or enumerate in a forward-only manner. Its declaration is as follows:

public interface IEnumerator  
{  
      bool MoveNext();  
object Current { get; }  
void Reset();  
}  
**MoveNext** advances the current element or “cursor” to the next position, returning
false if there are no more elements in the collection. **Current** returns the element
at the current position (usually cast from object to a more specific type). MoveNext
must be called before retrieving the first element—this is to allow for an empty collection.
The **Reset** method, if implemented, moves back to the start, allowing the
collection to be enumerated again. Reset exists mainly for COM interop; calling it
directly is generally avoided because it’s not universally supported (and is unneces‐
sary in that it’s usually just as easy to instantiate a new enumerator).

Collections do not usually implement enumerators; instead, they provide enumera‐
tors, via the interface IEnumerable:
public interface IEnumerable  
{  
IEnumerator GetEnumerator();  
}  
By defining a single method retuning an enumerator, **IEnumerable** provides 
flexibility in that the iteration logic can be farmed off to another class. Moreover, it
means that several consumers can enumerate the collection at once without inter‐
fering with each other. IEnumerable can be thought of as “IEnumeratorProvider,”
and it is the most basic interface that collection classes implement.

### Implementing the Enumeration Interfaces
You might want to implement IEnumerable or IEnumerable<T> for one or more of the following reasons:

- To support the foreach statement
- To interoperate with anything expecting a standard collection
- To meet the requirements of a more sophisticated collection interface
- To support collection initializers

To implement IEnumerable/IEnumerable<T>, you must provide an enumerator.
**You can do this in one of three ways:**
1. If the class is “wrapping” another collection, by returning the wrapped collection’s enumerator
2. Via an iterator using yield return
3. By instantiating your own IEnumerator/IEnumerator\<T> implementation

Returning another collection’s enumerator is just a matter of calling **GetEnumerator**
on the inner collection. However, this is viable only in the simplest scenarios, where
the items in the inner collection are exactly what are required. A more flexible
approach is to write an iterator, using C#’s yield return statement. An iterator is a
C# language feature that assists in writing collections, in the same way the foreach
statement assists in consuming collections. An iterator automatically handles the
implementation of IEnumerable and IEnumerator—or their generic versions.
### What is Enumerator ?

Think of an enumerator as a pointer indicating elements in a list. Initially, the pointer points before
the first element. You call the **MoveNext** method to move the pointer down to the next (first) item in
the list; the MoveNext method should return true if there actually is another item and false if there
isn’t. You use the **Current** property to access the item currently pointed to, and you use the **Reset**
method to return the pointer back to before the first item in the list. By creating an enumerator by
using the *GetEnumerator* method of a collection and repeatedly calling the MoveNext method and
retrieving the value of the Current property by using the enumerator, you can move forward through
the elements of a collection one item at a time. *This is exactly what the foreach statement does.* So,
``if you want to create your own enumerable collection class, you must implement the IEnumerable
interface in your collection class and also provide an implementation of the IEnumerator interface to
be returned by the GetEnumerator method of the collection class.``

If you are observant, you will have noticed that the **Current** property of the *IEnumerator* interface
exhibits non-type-safe behavior in that it returns an object rather than a specific type. However, you
should be pleased to know that the Microsoft .NET Framework class library also provides the generic
IEnumerator<T> interface, which has a Current property that returns a T, instead. Likewise, there is
also an IEnumerable<T> interface containing a GetEnumerator method that returns an Enumerator<T>
object. Both of these interfaces are defined in the System.Collections.Generic namespace, and if you
are building applications for the .NET Framework version 2.0 or later, you should make use of these
generic interfaces when defining enumerable collections rather than using the nongeneric version.

**Note:** The generic IEnumerator\<T> interface has some further differences from the
nongeneric IEnumerator interface: it does not contain a Reset method but extends the
IDisposable interface.

### Implementing an enumerator by using an iterator
As you can see, the process of making a collection enumerable can become complex and potentially
error-prone. To make life easier, C# provides iterators that can automate much of this process.

An ``iterator`` is a block of code that yields an ordered sequence of values. An iterator is not actually
a member of an enumerable class; rather, it specifies the sequence that an enumerator should use
for returning its values. In other words, an iterator is just a description of the enumeration sequence
that the C# compiler can use for creating its own enumerator. 