using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_camerasp : MonoBehaviour
{
    public Camera c1;
    public Camera c2;
    public Camera c3;
    public Camera c4;
    public Camera c5;
    Boolean triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!triggered)
        {
            triggered = true;
            c1.enabled = true;
            c2.enabled = false;
            c3.enabled = false;
            c4.enabled = false;
            c5.enabled = false;
            print("switching to " + c1);
        }
    }
}
