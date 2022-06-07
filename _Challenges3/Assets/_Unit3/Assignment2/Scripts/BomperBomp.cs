using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomperBomp : MonoBehaviour
{
    public Material bompMaterial;
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material = bompMaterial;
        gameManager.coinCounter += 1;

        Destroy(this);
       
    }
}
