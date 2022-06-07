using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public Material hitMaterial;
    public GameManager gameManager;

    [SerializeField] private AudioSource counterCush;

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().material = hitMaterial;
        gameManager.AddScore(3);
        counterCush.Play();

        // set hits on game logic
        Destroy(this);
    }
}

