using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliasMoveParticals : MonoBehaviour
{
    ///this script to be added to the particles prefab
    //reduces the scale as time goes and eventually becomes of scale zero
    //and is destroyed

    [SerializeField] private Transform m_explodingBitsTransform;

    private float m_xPosition;
    private float m_yPosition;
    private float m_zPosition;

    public float m_destroyBitsTime;
    public float randomAxis;

    public AudioSource audioSource;

    private AudioClip m_explosion;

    private void Start()
    {
        m_explodingBitsTransform = this.m_explodingBitsTransform.transform.GetComponent<Transform>();
    }

    void Update()
    {
        ExplodeDirection();
    }

    void ExplodeDirection()//send the particles towards a random range
    {
        audioSource.PlayOneShot(m_explosion, 1f);

        float m_xPos = Random.Range(randomAxis, -randomAxis);
        float m_yPos = Random.Range(randomAxis, -randomAxis);
        float m_zPos = Random.Range(randomAxis, -randomAxis);

        transform.Translate(m_xPos, m_yPos, m_zPos);

        m_explodingBitsTransform.localScale -= new Vector3(.005f, .005f, .005f);

        if (m_explodingBitsTransform.localScale.z <= 0)
        {
            m_explodingBitsTransform.localScale = new Vector3(.0f, .0f, .0f);

        }
        Destroy(this.gameObject, m_destroyBitsTime);

    }
}
