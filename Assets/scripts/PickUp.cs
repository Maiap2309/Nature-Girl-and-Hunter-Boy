using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private GameObject myObject;
    private bool touchingObject;
    private bool holdingObject;
    public KeyCode pick;
    public bool movementChange;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pick) && touchingObject && !holdingObject)
        {
            holdingObject = true;
        }
        else if (Input.GetKeyDown(pick) && holdingObject)
        {
            holdingObject = false;
            myObject = null;
        }

        if (holdingObject)
            HoldObject();
    }

    void HoldObject()
    {
        myObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        myObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        if(!movementChange)
        {
            if (transform.eulerAngles.y < 269.9f)
            {
                myObject.transform.position = new Vector3(transform.position.x + 1.5f, transform.position.y + 0.5f, myObject.transform.position.z);
            }
            else
            {
                myObject.transform.position = new Vector3(transform.position.x - 1.5f, transform.position.y + 0.5f, myObject.transform.position.z);
            }
        }
        else
        {
            if (transform.eulerAngles.y <= 0.1)
            {
                myObject.transform.position = new Vector3(transform.position.x + 1.5f, transform.position.y + 0.5f, myObject.transform.position.z);
            }
            else
            {
                myObject.transform.position = new Vector3(transform.position.x - 1.5f, transform.position.y + 0.5f, myObject.transform.position.z);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Object" && !holdingObject)
        {
            touchingObject = true;
            myObject = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Object")
        {
            touchingObject = false;
        }
    }
}