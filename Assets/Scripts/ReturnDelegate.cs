using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnDelegate : MonoBehaviour
{

    //public delegate int CharacterLength(string text);

    public Func<string, int> CharacterLength;

    void Start()
    {

        CharacterLength = (name) => name.Length;

        int count = CharacterLength("Kenny");

        Debug.Log("Count: " + count);

    }


    void Update()
    {
        
    }

    //int GetCharacters(string name)
    //{
    //    return name.Length;
    //}

}
