using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_end : MonoBehaviour
{
    public Rigidbody2D ball;
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
        ball.mass = 0.5f;
        ball.gravityScale = 10;
    }
}
