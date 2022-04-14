using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pythagoras : MonoBehaviour
{


    private void Start()
    {
        HypotenuseLength();
    }

    private void HypotenuseLength()
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
       
    }

    private float HypotenuseLength(float sideALength, float sideBLength)
    {
        return Mathf.Sqrt(sideALength * sideALength + sideBLength * sideBLength);
    }

  
}