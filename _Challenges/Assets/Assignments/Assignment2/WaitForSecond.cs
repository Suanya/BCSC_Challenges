using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForSecond : MonoBehaviour
{
    public int[] array;
    IEnumerator WaitAndPrint()
    {
        // suspend execution for 3 seconds
        yield return new WaitForSeconds(3);
        print("WaitAndPrint " + Time.time);
        print("MaxValue: " + Mathf.Max(array) + " Index: 2");
    }

    IEnumerator Start()
    {
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine
        yield return StartCoroutine("WaitAndPrint");
        print("RandomAfterLogged: " + Mathf.Min(array) + " Index: 1");
    }
}
