using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoy : MonoBehaviour
{
    public float speed;
    public bool playerIsOnTheGround = true;
    public float jumpForce;
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(left))
        {
            GetComponent<Transform>().position -= new Vector3(speed, 0, 0) * Time.deltaTime;
            rotateMove(270);
            GetComponent<Animator>().SetBool("move", true);
        }
        else if (Input.GetKey(right))
        {
            GetComponent<Transform>().position += new Vector3(speed, 0, 0) * Time.deltaTime;
            rotateMove(90);

            GetComponent<Animator>().SetBool("move", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("move", false);
        }
        if (Input.GetKeyDown(jump) && playerIsOnTheGround)
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);



    }

    private void rotateMove(float dir)
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, dir, transform.eulerAngles.z);
        print(dir);
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            playerIsOnTheGround = true;
    }


    private void OnCollisionExit(Collision collision)

    {
        if (collision.gameObject.tag == "Ground")
            playerIsOnTheGround = false;
    }
}


