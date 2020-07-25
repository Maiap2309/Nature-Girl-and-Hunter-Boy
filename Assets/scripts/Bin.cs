using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{   
    public int binType;
    public PickUp script;
    void Start ()
    {
        script = FindObjectOfType < PickUp >();
    }
    void OnTriggerEnter(Collider col)
    {
        if(binType == 0)
        {
            if (col.tag == "Compost")
            {   
                script.myObject = null;
                script.holdingObject=false;
                Destroy(col.gameObject);
           
              
            }
        } 
        else if(binType == 1)
        {
             if (col.tag == "Recycling")
            {
                script.myObject = null;
                script.holdingObject=false;
                Destroy(col.gameObject);
            }
        }
        else if(binType == 2)
        {
             if (col.tag == "Trash")
            {   
                script.myObject = null;
                script.holdingObject=false;
                Destroy(col.gameObject);
            }
        }

    }
    
}
