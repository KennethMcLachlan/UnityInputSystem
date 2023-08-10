using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateNoParam : MonoBehaviour
{

    public Action onGetName;

    

    void Start()
    {
        onGetName = () =>
        {
            Debug.Log("Name: " + gameObject.name);
            Debug.Log("I'm tired");
        };

        onGetName();

    }


    void Update()
    {
        
    }

    //void GetName()
    //{
    //    Debug.Log("Name: " + gameObject.name);
    //}

}
