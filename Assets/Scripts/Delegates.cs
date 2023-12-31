using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Delegates : MonoBehaviour
{

    public delegate void ChangeColor(Color newColor);

    public ChangeColor onColorChange;

    public delegate void OnComplete();
    public OnComplete onComplete;


    // Start is called before the first frame update
    void Start()
    {
        onColorChange = UpdateColor;
        onColorChange(Color.green);

        onComplete += Task;
        onComplete += Task2;
        onComplete += Task3;

        if (onComplete != null)
            onComplete();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateColor(Color newColor)
    {
        Debug.Log("Changing Color to: " + newColor.ToString());
    }

    public void Task()
    {
        Debug.Log("Task Finished");
    }

    public void Task2()
    {
        Debug.Log("Task 2 Finished");
    }

    public void Task3()
    {
        Debug.Log("Task 3 Finished");
    }

}
