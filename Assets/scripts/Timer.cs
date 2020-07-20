using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{   public float timer;
    public bool gameRunning;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        gameRunning=true;
    }

    // Update is called once per frame
    void Update()
    {   
        if(gameRunning)
        timer+=Time.deltaTime;
        GetComponent<TMPro.TextMeshProUGUI>().text=timer.ToString();
    }
}
