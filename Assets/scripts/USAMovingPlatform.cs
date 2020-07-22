using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USAMovingPlatform : MonoBehaviour
{   
    public GameObject trashCounter;
    bool completed;
    public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        completed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!completed && trashCounter.transform.childCount <= 0)
        {
            completed = true;
            platform.transform.position = new Vector3(platform.transform.position.x,platform.transform.position.y+3,platform.transform.position.z);
        }

    }
}
