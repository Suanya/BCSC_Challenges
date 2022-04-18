using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// * turn in a specific angle
/// * move to a specific point
/// * wait 1 second, then fire up
/// </summary>

public class MoveAndShoot : MonoBehaviour
{
    public float smoothing = 1f;
    public Transform target;

    private void Start()
    {
        StartCoroutine(MyCoroutine(target));
    }

    IEnumerator MyCoroutine(Transform target)
    {
        while(Vector3.Distance(transform.position, target.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);
            yield return null;
        }

        print("Reached targed");

        yield return new WaitForSeconds(3f);

        print("CoroDone");
    }
}
