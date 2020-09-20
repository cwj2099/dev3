using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_launch : MonoBehaviour
{
    public Camera c;
    public Camera c1;
    public Camera c2;
    public Camera c3;
    public Camera c4;
    public Camera c5;
    public Camera c6;
    public Camera c7;
    public Camera c8;
    public Camera c9;
    public Vector2 launchForce = new Vector2(100, 0);
    public int launchTime = 10;
    public Rigidbody2D toShot;
    Boolean triggered=false;
    // Start is called before the first frame update
    void Start()
    {
        c.enabled = true;
        c1.enabled = false;
        c2.enabled = false;
        c3.enabled = false;
        c4.enabled = false;
        c5.enabled = false;
        c6.enabled = false;
        c7.enabled = false;
        c8.enabled = false;
        c9.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            triggered = true;
        }

        if (triggered&&launchTime>0)
        {
            //print("launch");
            toShot.AddForce(launchForce);
            launchTime--;
        }
    }

}
