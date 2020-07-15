using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public string name;
    public GameObject canvas;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag== name)
        {
            canvas.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
