using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //public delegate void OnDamgeRecieved(int currentHealth);
    //public static event OnDamgeRecieved onDamage;

    public static Action<int> OnDamageReceived;

    public int Health { get; set; }

    void Start()
    {
        Health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        Health--;

        if (OnDamageReceived != null)
            OnDamageReceived(Health);
    }

}
