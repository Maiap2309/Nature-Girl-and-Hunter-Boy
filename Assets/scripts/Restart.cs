using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject canvas;
    public bool killBoth; 
    public string name;
    private void OnTriggerEnter(Collider other)
    {   
        if (killBoth)
        {
            if(other.tag == "NatureGirl" || other.tag =="HunterBoy")
            {
                canvas.SetActive(true);
                FindObjectOfType<Timer>().gameRunning=false;
                Destroy(other.gameObject);
            }

        }
        else 
        {
            if (other.tag == name)
            {
                canvas.SetActive(true);
                FindObjectOfType<Timer>().gameRunning=false;
                Destroy(other.gameObject);
            }
        }
        
    }
}

