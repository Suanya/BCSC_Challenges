using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public Material hitMaterial;
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().material = hitMaterial;
        gameManager.coinCounter += 3;

        // set hits on game logic
        Destroy(this);
    }
}

