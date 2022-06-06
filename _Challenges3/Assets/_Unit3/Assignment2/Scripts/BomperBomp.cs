using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomperBomp : MonoBehaviour
{
    public Material bompMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material = bompMaterial;
       
    }
}

