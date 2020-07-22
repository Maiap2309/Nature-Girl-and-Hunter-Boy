using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject myObject;
    private bool touchingObject;
    public bool holdingObject;
    public KeyCode pick;
    public bool movementChange;
    // Update is called once per frame
    void Update()
    {   
        //print(holdingObject);
        if (Input.GetKeyDown(pick) && touchingObject && !holdingObject)
        {
            holdingObject = true;
        }
        else if (Input.GetKeyDown(pick) && holdingObject)
        {
            myObject.GetComponent<Rigidbody>().detectCollisions = true;
            holdingObject = false;
            myObject = null;
        }

        if (holdingObject)
            HoldObject();
    }

    void HoldObject()
    {
        print(movementChange);
        myObject.GetComponent<Rigidbody>().detectCollisions = false;
        myObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        myObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        /*
        if(!movementChange)
        {
            if (transform.eulerAngles.y < 179.9f)
            {
                myObject.transform.position = new Vector3(myObject.transform.position.x, transform.position.y + 0.5f, transform.position.z+1.5f);
            }
            else
            {
                myObject.transform.position = new Vector3(myObject.transform.position.x, transform.position.y + 0.5f, transform.position.z-1.5f);
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
        */
         myObject.transform.position = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
    }

    private void OnTriggerStay(Collider other)
    {
        if ((other.tag == "Compost" || other.tag == "Recycling" || other.tag == "Trash") && !holdingObject)
        {
            touchingObject = true;
            myObject = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((other.tag == "Compost" || other.tag == "Recycling" || other.tag == "Trash"))
        {
            touchingObject = false;
        }
    }
}