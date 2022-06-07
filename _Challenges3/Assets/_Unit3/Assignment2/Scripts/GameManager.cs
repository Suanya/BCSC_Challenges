using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    
    public GameObject victoryCanvas;
    public GameObject ball;
    
    [SerializeField] private TMP_Text coinCounterText;
    public int coinCounter;
    

    // Update is called once per frame

    void Update()
    {
        

        if(coinCounter >= 20)
        {
            victoryCanvas.SetActive(true);
            Destroy(ball);
            Destroy(this);
        }
    }

    public void AddScore(int points)
    {

        coinCounter += points;
        coinCounterText.text = coinCounter.ToString();

    }

   

}
