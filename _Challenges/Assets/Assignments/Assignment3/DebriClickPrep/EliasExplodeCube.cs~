using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliasExplodeCube : MonoBehaviour
{
    //Add this script to the initial cube
    //Spawns particles in a specific location which aligns with initial cube
    //Player able to define how many particles to instantiate

    [SerializeField] public GameObject m_cube;//initial cube

    [SerializeField] public GameObject m_explodingBits;//prefab particle

    public float m_numberOfPartices;//number of particles to instantiate

    private float m_xPosition; //sets parameters on x axis
    private float m_yPosition; //sets parameters on y axis
    private float m_zPosition; //sets parameters on z axis

    void Update()
    {
        //upon click deactivate original cube, instantiate particles, execute explosion method

        if (Input.GetMouseButtonDown(0))
        {
            m_cube.SetActive(false);//deactivate initial cube

            SpawnPositions();
            ExplodeDirection();
        }
    }


    // Update is called once per frame
    void ExplodeDirection()//instantiate particles
    {
        for (int i = 0; i < m_numberOfPartices; i++)
        {
            Instantiate(m_explodingBits, SpawnPositions(), Quaternion.identity);
        }
    }

    Vector3 SpawnPositions()//defines instantiation locations
    {
        float m_xPos = Random.Range(.90f, -.90f);
        float m_yPos = Random.Range(.90f, -.90f);
        float m_zPos = Random.Range(.90f, -.90f);

        return new Vector3(m_xPos, m_yPos, m_zPos);

    }

}
