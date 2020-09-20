using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_rocketStart : MonoBehaviour
{
    public Vector2 launchForce = new Vector2(100, 0);
    public int launchTime = 60;
    public int waitTime = 60;
    public Rigidbody2D toShot;
    public Rigidbody2D toFloat;
    Boolean triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            if (triggered && launchTime > 0 && waitTime <= 0)
            {
                //print("launch");
                toShot.AddForce(launchForce);
                Destroy(toShot.GetComponent<HingeJoint2D>());
                launchTime--;
                toFloat.GetComponent<Rigidbody2D>().mass = 0;
            }
            else
            {
                waitTime--;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("entered");
        triggered = true;
    }
}
