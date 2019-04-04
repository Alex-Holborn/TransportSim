using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : ScriptableObject
{
    public string CustomerName { get; private set; }

    public void SetCustomerName(string name)
    {
        CustomerName = name;
    }
}
