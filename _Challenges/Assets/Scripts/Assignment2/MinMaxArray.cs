using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Instructions:
/// create a function that, given an array of numbers, finds and logs the valure and index of the largest number
///     * array must be adable through the inspector
///     * function must be called every 3 seconds
///     * largest number must be swapped with a random after logging
///
/// Deliverables:
/// calss that logs the largest nnumber and index in the Start() and Update() function
/// </summary>

public class MinMaxArray : MonoBehaviour
{
    public int[] array;

    float x = 1.0f;
    float y = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("max", x, y);
    }

    
    // Update is called once per frame
    void Update()
    {
        var max = Mathf.Max(array);
        Debug.Log(max);
    }
    
    /*
    IEnumerator ArrayCoroutine()
    {
        // print time when function is first called
        Debug.Log("Started ArrayCoroutine at timestamp : " + Time.time);

        // yield on a new YieldInstruction that waits for 3 seconds
        yield return new WaitForSeconds(3);

        //After we've waited 3 seconds, print time again
        Debug.Log("Finished ArrayCoroutine at timestamp : " + Time.time);
    }
    */
}
