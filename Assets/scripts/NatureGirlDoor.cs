using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureGirlDoor : MonoBehaviour
{
    public bool touching;
    // Start is called before the first frame update
    void Start()
    {
        touching = false;
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "NatureGirl")
        {
            touching = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "NatureGirl")
        {
            touching = false;
        }
    }


}
