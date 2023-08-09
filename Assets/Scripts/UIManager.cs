using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void UpdateHealth(int health)
    {
        Debug.Log("Current Health: " + health);
    }

    public void OnEnable()
    {
        Player.OnDamageReceived += UpdateHealth;
    }
}
