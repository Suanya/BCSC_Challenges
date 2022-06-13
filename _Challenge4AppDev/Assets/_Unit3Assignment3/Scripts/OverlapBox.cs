using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Using OverlapBox that creates an invisible BoxCollider that detects multiple collisions with other collider.
/// The OverlapBox in this case has the same size and position as the GameObject it's attached to.
/// Acting as a replacement for the BoxCollider component.
/// </summary>

public class OverlapBox : MonoBehaviour
{
    bool m_Started;
    public LayerMask m_LayerMask;

    


    // Start is called before the first frame update
    void Start()
    {
        // making sure the Gizmos are being drawn while playing
        m_Started = true;
    }

    private void FixedUpdate()
    {
        MyCollision();
    }

    private void MyCollision()
    {
        // use the OverlapBox to detect if there are any other colliders within this box area.
        // use the GameObject's center, half the size (as a radius) and rotation. This creates an invisible box around your GameObject.
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity, m_LayerMask);
        int i = 0;

        // check when there is a new collider coming into contact with the box
        while (i < hitColliders.Length)
        {
            // output all of the collider names
            Debug.Log("Hit: " + hitColliders[i].name + i);
            

            // increase the number of colliders in the array
            i++;
        }
    }

    // Draw the BoxOverlap as a Gizmo to show where it currently is testing. Click the Gizmos button to see this
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        // check that is being run in PlayMode, so it doesn't try to draw this in Editor mode
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }


}
