using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DebriClick : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private float position;
    [SerializeField] private float gravity;
    [SerializeField] private float acceleration;

    // Start is called before the first frame update
    public void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        position += velocity;
        velocity += acceleration;
        acceleration = gravity;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
