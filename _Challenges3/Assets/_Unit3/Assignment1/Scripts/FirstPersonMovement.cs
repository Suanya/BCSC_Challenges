using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // per second instead of per frame
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // move translation along object's z-axis
        transform.Translate(0, 0, translation);

        // rotate aroung our y-axis
        transform.Rotate(0, rotation, 0);
    }
}
