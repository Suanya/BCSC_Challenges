using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/// <summary>
/// * allow multiple users to save their data:
/// * Serialize the data to JSON and save it to a file
/// * Create a new scene that only displays the info of a selected user entry and a return button.
/// * Add buttons on the sign-up page to visualize each user's info.
/// </summary>

public class JsonTest : MonoBehaviour
{
    public static JsonTest instance;

    bool isGameActive;

    // values 
    [SerializeField] private TextMesh nameText;
    [SerializeField] private TextMeshPro ageText;
    [SerializeField] private TextMeshPro cityText;
    [SerializeField] private TextMeshPro weightText;


    private void Awake()
    {
        isGameActive = true;

        if(instance == null)
        {
            Debug.LogError("too many singeltons, mister!");
        }

        if (File.Exists(Application.dataPath + "/SaveData.json"))
        {
            string json = File.ReadAllText(Application.dataPath + "/Save.Data.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);
        }
            
    }



}