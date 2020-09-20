using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_camera_tracking : MonoBehaviour
{
    public GameObject toTrack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (toTrack.transform.position.x,toTrack.transform.position.y,-10); 
    }
}
