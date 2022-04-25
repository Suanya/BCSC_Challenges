using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class DebriMove : MonoBehaviour
{

    
    public float velocity = 3.0f;
    public float position;
    public float gravity = 9.0f;
    public float acceleration = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        position += velocity;
        velocity += acceleration;
        acceleration = gravity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
