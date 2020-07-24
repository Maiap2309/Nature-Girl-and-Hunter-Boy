using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform2 : MonoBehaviour
{
    public Vector3 pos1;
    public Vector3 pos2;
    public float speed;
    private bool movingToPos1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movingToPos1)
        {
            Vector3 difference = pos1 - transform.position;
            transform.position = Vector3.MoveTowards(transform.position, pos1, speed * Time.deltaTime);
            if (difference.magnitude < .1f)
            {
                movingToPos1 = false;
            }
        }
        else
        {
            Vector3 difference = pos2 - transform.position;
            transform.position = Vector3.MoveTowards(transform.position, pos2, speed * Time.deltaTime);
            if (difference.magnitude < .1f)
            {
                movingToPos1 = true;
            }
        }
    }
}
