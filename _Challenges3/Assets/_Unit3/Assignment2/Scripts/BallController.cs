using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 5;
    bool canMove = true;
    public float limitLeft = -5.2f;
    public float limitRight = 5.2f;
    public float resetHeight = 7f;
    


    // Update is called once per frame
    void Update()
    {
        if(canMove == true) 
        {
            Vector3 moveOffset = Vector3.zero;
            moveOffset.x = Input.GetAxis("Horizontal");
            moveOffset.x = moveOffset.x * moveSpeed * Time.deltaTime;
            Vector3 newPosition = transform.position + moveOffset;

            if(newPosition.x > limitRight)
            {
                newPosition.x = limitRight;
            }
            if(newPosition.x < limitLeft)
            {
                newPosition.x = limitLeft;
            }

            transform.position = newPosition;

            if(Input.GetButton("Fire1"))
            {
                canMove = false;
                GetComponent<Rigidbody>().isKinematic = false;
                GetComponent<Rigidbody>().AddForce(Random.Range(-5f, 5f), 0, 0, ForceMode.Impulse);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bottom")
        { 
            canMove = true;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.position = new Vector3(0, resetHeight, 0);
        }
    }
}
