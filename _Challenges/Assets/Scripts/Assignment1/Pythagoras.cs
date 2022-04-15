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


    
    // MitternachtsFormel
    public static int SolveQuadric(double c0, double c1, double c2, out double s0, out double s1)
    {
        s0 = double.NaN;
        s1 = double.NaN;

        double p, q, D;

        // normal form: x^2 + px + q = 0 
        p = c1 / (2 * c0);
        q = c2 / c0;

        D = p * p - q;

        var IsZero = 0;

        if (IsZero == D)
        {
            s0 = -p;
            return 1;
        }
        else if (D < 0)
        {
            return 0;
        }
        else // if (D > 0) 
        {
            double sqrt_D = System.Math.Sqrt(D);

            s0 = sqrt_D - p;
            s1 = -sqrt_D - p;
            return 2;
        }
    }
    

}