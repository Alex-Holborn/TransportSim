using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : ScriptableObject
{
    public int JobId { get; private set; }
    
    public Customer JobCustomer { get; private set; }

    public void SetJobCustomer(Customer c)
    {
        JobCustomer = c;
    }

    public void SetJobId(int id)
    {
        JobId = id;
    }
}
