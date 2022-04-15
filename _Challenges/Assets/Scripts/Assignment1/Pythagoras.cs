using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pythagoras : MonoBehaviour
{
    private void Start()
    {
        // HypotenuseLength(2, 5);
        Debug.Log(HypotenuseLength(2,5));
    }
  
    private void Update()
    {
        
      
    }

    private float HypotenuseLength(float sideALength, float sideBLength)
    {
        return Mathf.Sqrt(sideALength * sideALength + sideBLength * sideBLength);
    }
}