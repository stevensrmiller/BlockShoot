using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Counter")]
public class Counter : ScriptableObject
{
    public event System.Action Over;

    int count;

    private void OnEnable()
    {
        count = 0;
        Over = null;
    }

    public void ReStart()
    {
        OnEnable();
    }

    public void AddOne()
    {
        count++;
    }

    public void SubOne()
    {
        count--;

        if (count == 0)
        {
            Over();
        }
    }
}
