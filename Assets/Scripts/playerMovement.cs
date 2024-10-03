using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class playerMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;

    private Vector3 nextPosition;

    private void FixedUpdate() {
        Vector3 forwardMove  = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            nextPosition = new Vector3(-3.3f,rb.position.y,rb.position.z);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            nextPosition = new Vector3(3.3f,rb.position.y,rb.position.z);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            nextPosition = new Vector3(0,rb.position.y,rb.position.z)
        } 
    }
}
