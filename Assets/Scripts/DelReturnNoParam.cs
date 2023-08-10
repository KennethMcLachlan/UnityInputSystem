using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelReturnNoParam : MonoBehaviour
{

    public Func<int> onGetName;



    //int GetName()
    //{
    //    return this.gameObject.name.Length;
    //}

    void Start()
    {
        onGetName = () => gameObject.name.Length;

        int CharacterCount = onGetName();

        Debug.Log("Character Count: " + CharacterCount);
    }

    void Update()
    {
        
    }
}
