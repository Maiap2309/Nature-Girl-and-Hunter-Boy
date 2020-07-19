using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoozyMove : MonoBehaviour
{
    public float speed;
    public bool playerIsOnTheGround = true;
    public float jumpForce;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().position -= new Vector3(0, 0, speed) * Time.deltaTime;
            rotateMove(180);
            GetComponent<Animator>().SetBool("move", true);
        }


        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().position += new Vector3(0, 0, speed) * Time.deltaTime;
            rotateMove(0);
            GetComponent<Animator>().SetBool("move", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("move", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && playerIsOnTheGround)
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


