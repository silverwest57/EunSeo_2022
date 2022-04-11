using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecube : MonoBehaviour
{
    private bool inOn = true;
    private Vector3 StartPos;
    //Start is called before the first frame update 
    void Start()
    {
        Debug.Log("Hello World");
        StartPos=transform.position;
    }
        //Update is called once per frame void Update()
        
    
    public void StopCube()
    {
        inOn=false;

        transform.position=StartPos;
    }

    // Update is called once per frame
    void Update()
    {
        if(inOn)
        {
            transform.Translate(Vector3.left*Time.deltaTime);
        }
    }
}
