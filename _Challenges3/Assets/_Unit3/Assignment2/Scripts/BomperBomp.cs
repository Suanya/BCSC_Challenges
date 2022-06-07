using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomperBomp : MonoBehaviour
{
    public Material bompMaterial;
    public GameManager gameManager;

    [SerializeField] private AudioSource bomperPop;


    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material = bompMaterial;
        gameManager.AddScore(1);
        bomperPop.Play();

        Destroy(this);
       
    }
}
