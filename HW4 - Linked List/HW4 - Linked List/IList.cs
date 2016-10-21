using System;
//JaJuan Webster
//HW-4: Linked List
//Professor Steve Maier

/// <summary>
/// The interface for a simple Linked List
/// </summary>
public interface IList
{
    //Add a new element to the end of the list.
    void Add(String data);

    //Inserts a new element at a specified location in the list.
    void Insert(String data, int index);

    //Remove an element from a specified location in 
    //the list and return the data
    String Remove(int index);

    //Return the element at this index in the list.
    String GetElement(int index);

    //Clears the list
    void Clear();

    //The current number of items in this list.
    int Count { get; }

}
