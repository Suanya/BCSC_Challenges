using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitterNachtsFormel : MonoBehaviour
{
    // Solve quadratic equation: c0*x^2 + c1*x + c2. 
    // Returns number of solutions.
    public static int SolveQuadric(double c0, double c1, double c2, out double s0, out double s1)
    {
        s0 = double.NaN;
        s1 = double.NaN;

        double p, q, D;

        /* normal form: x^2 + px + q = 0 */
        p = c1 / (2 * c0);
        q = c2 / c0;

        D = p * p - q;

        if (IsZero(D))
        {
            s0 = -p;
            return 1;
        }
        else if (D < 0)
        {
            return 0; 
        }
        else /* if (D > 0) */
        {
            double sqrt_D = System.Math.Sqrt(D);

            s0 = sqrt_D - p;
            s1 = -sqrt_D - p;
            return 2;
        }
        Debug.Log(SolveQuadric(2));
    }

    private static object SolveQuadric(int v)
    {
        throw new NotImplementedException();
    }

    private static bool IsZero(double d)
    {
        throw new NotImplementedException();
    }
}
