using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeCubeScript : MonoBehaviour
{
    // Create a program using delegates and events where you hit the space key and assign a 
    //Cube a position of (5,2,0)

    //The Cube script should subscribe to the event and be invoked whern you hit
    //The space key

    void Start()
    {
        
            SpaceKEy.onTeleport += Spawn;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
    }

    private void OnDisable()
    {
        {
            SpaceKEy.onTeleport -= Spawn;
        }
    }
}
