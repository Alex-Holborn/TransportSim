using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder<T> : ScriptableObject
{
    public List<T> OwnedList { get; private set; }

    void Awake()
    {
        OwnedList = new List<T>();
    }

    public bool AddItem(T item)
    {
        if (OwnedList == null)
        {
            OwnedList = new List<T>();
        }
        if (!OwnedList.Contains(item))
        {
            OwnedList.Add(item);
            return true;
        }
        return false;
    }

    public bool RemoveItem(T item)
    {
        if (OwnedList == null)
        {
            OwnedList = new List<T>();
            return false;
        }
        if (OwnedList.Contains(item))
        {
            OwnedList.Remove(item);
            return true;
        }
        return false;
    }
}
