using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliasHammer : MonoBehaviour
{
    [SerializeField] private BoxCollider boxCollider;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ball"))
            return;
        Debug.Log("ball hit");

        var position = transform.position + boxCollider.size.y / 2 * Vector3.up;
        var halfExtents = Vector3.Scale(transform.lossyScale, boxCollider.size) / 2;
        var layerMask = LayerMask.GetMask("Shakeables");
        Debug.Log(LayerMask.GetMask());

        var colliders = Physics.OverlapBox(
            position,
            halfExtents,
            transform.rotation,
            layerMask);
        Debug.Log("physics overlap");

        foreach (var other in colliders)
        {
            Debug.Log("var in colliders");

            other.GetComponent<Animator>().SetTrigger("Shake");//shake is the name of the parameter in the animator. Remember to have an idle state before action or it will shake immediately upon play
        }
    }
}
