using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterBoyDoor : MonoBehaviour
{
    public bool touching;
    // Start is called before the first frame update
    void Start()
    {
        touching = false;  
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "HunterBoy")
        {
            touching = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "HunterBoy")
        {
            touching = true;
        }
    }
}
