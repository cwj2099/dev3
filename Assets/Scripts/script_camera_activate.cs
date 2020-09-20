using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_camera_activate : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera c1;
    public Camera c2;
    Boolean triggered = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!triggered) {
            triggered = true;
            c1.enabled = true;
            c2.enabled = false;
            print("switching to " + c1);
        }
    }
}
