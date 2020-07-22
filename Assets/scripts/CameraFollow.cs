using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{   
    public Transform natureGirl;
    public Transform hunterBoy;
    private Transform reference;
    public bool movementChange;
    private bool cameraChange;
    public KeyCode change;
    // Start is called before the first frame update
    void Start()
    {   
        reference = natureGirl;
        cameraChange = true;
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(change))
        {
            if (cameraChange)
            {
                reference = hunterBoy;
                cameraChange = false;
            }
            else 
            {
                reference = natureGirl;
                 cameraChange = true;
            }
        }

        if (!movementChange)
        {
            transform.position=new Vector3(transform.position.x, reference.position.y, reference.position.z);
        }
        else
        {
            transform.position=new Vector3(reference.position.x, reference.position.y, transform.position.z);
        }
    }
}
