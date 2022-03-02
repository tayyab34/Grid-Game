using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SetBoundary bound;
    void Start()
    {
        bound = GameObject.Find("Boundary").GetComponent<SetBoundary>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && bound.forwardMove==true)
        {
         transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 3);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && bound.backwardMove == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-3);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && bound.rightMove==true)
        {
            transform.position = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && bound.leftMove==true)
        {
            transform.position = new Vector3(transform.position.x-3, transform.position.y, transform.position.z);
        }
    }
}
