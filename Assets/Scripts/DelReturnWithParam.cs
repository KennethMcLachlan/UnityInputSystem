using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelReturnWithParam : MonoBehaviour
{

    public Func<int, int, int> onCalculateSum;

    private void Start()
    {
        onCalculateSum = (a, b) =>
        {
            return a + b;
        };

        var total = onCalculateSum(5, 5);

        Debug.Log("Total: " + total);
    }

    //int CalculateSum(int a, int b)
    //{
    //    return a + b;
    //}


}
