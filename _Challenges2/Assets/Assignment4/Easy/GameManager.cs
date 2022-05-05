using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager s_instance;

    [SerializeField] private TextMeshProUGUI nameHeaderText;
    [SerializeField] private TextMeshProUGUI ageHeaderText;
    [SerializeField] private TextMeshProUGUI cityHeaderText;
    [SerializeField] private TextMeshProUGUI weightHeaderText;

    // values which want to be saved (noBool!)
    private string nameInput = "nameInput";
    private int ageInput;
    private string cityInput;
    private int weighInput;

    // key which adresses the data being saved -> if you're looking for value, you use the key
    string nameKey = "nameInput";
    private int ageKey;
    private string cityKey;
    private int weighKey;

    /*
    private void Awake()
    {
        if(s_instance == null)
        {
            s_instance = this;
        }
        else
        {
            Debug.LogError("tooMuchSingleton, Mister!");
        }

        //if (PlayerPrefs.HasKey("nameInput"));

        if (PlayerPrefs.HasKey("nameKey"))
        {
            AddInput();
        }
    }
    */


    private void WelcomeAction()
    {
        PlayerPrefs.SetString("nameInpute", "nameKey");
        PlayerPrefs.GetString("nameKey");
    }

    private void AddInput()
    {
        nameKey += nameInput;
        nameInput = "nameInput" + nameInput;

        

    }
}


/*
 * void Example()
    {
        PlayerPrefs.SetString("Value", "Key");

        // call it
        PlayerPrefs.GetString("Value"); // "Key" comes out

        // delete all
        PlayerPrefs.DeleteAll();
    }
 * 
 */