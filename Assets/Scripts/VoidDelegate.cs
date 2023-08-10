using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidDelegate : MonoBehaviour
{

    public Action<int, int> Sum;

    void Start()
    {
        Sum = (a, b) =>
        {
            var total = a + b;

            if (total < 100)
            {
                Debug.Log("Total is less than 100");
            }

            Debug.Log("Total: " + total);
        };

        Sum(5, 2);
    }


    void Update()
    {
        
    }

    void CalculateSum(int a, int b)
    {
        var total = a + b;
    }
}
