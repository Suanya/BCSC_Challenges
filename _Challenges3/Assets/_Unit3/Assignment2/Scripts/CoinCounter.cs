using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public Material hitMaterial;

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().material = hitMaterial;

        // set hits on game logic
        Destroy(this);
    }
}

