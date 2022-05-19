using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;


/// <summary>
/// * Serialize the data to JSON and save it to a file
/// * Create a new scene that only displays the info of a selected user entry and a returnBtn
/// * Add buttons on the sign-up page to visualize each user's info
///
/// The scripts
/// * Detect that the sign-in submitBtn was clicked
/// * Gather information from the sign-up fields
/// * Store JSON serianized information using PlayerPrefs
/// * List and display every stored user entry
/// </summary>

public class Assi4Hard : MonoBehaviour
{
    public static Assi4Hard s_instance;

    // Values
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField ageInput;
    [SerializeField] private TMP_InputField cityInput;
    [SerializeField] private TMP_InputField weightInput;

    /*
    [SerializeField] private TMP_InputField nameInputPupil;
    [SerializeField] private TMP_InputField ageInputPupil;
    [SerializeField] private TMP_InputField cityInputPupil;
    [SerializeField] private TMP_InputField weightInputPupil;
    */

    // Key
    private string m_name; // value of the key (not yet) -> emptyBox
    private const string key_name = "NameKey"; // CONST -> constantAlways

    private string m_age;
    private const string key_age = "AgeKey";

    private string m_city;
    private const string key_city = "CityKey";

    private string m_weight;
    private const string key_weight = "WeightKey";

    private void Awake()
    {
        if(s_instance == null)
        {
            s_instance = this;
        }
        else
        {
            Debug.LogError("tooManySingleton, Mister");
        }

        if(File.Exists(Application.dataPath + "/SaveHardData.json"))
        {
            // check if key exists already and if so, take it and show it
            m_name = PlayerPrefs.GetString(key_name);
            nameInput.text = m_name.ToString();
            Debug.Log(m_name);

            m_age = PlayerPrefs.GetString(key_age);
            ageInput.text = m_age.ToString();
            Debug.Log(m_age);

            m_city = PlayerPrefs.GetString(key_city);
            cityInput.text = m_city.ToString();
            Debug.Log(m_city);

            m_weight = PlayerPrefs.GetString(key_weight);
            weightInput.text = m_weight.ToString();
            Debug.Log(m_weight);
        }      
    }

    /*
    private void OnApplicationQuit()
    {
        UpdateValues();
        
    }
    */

    public void OnClick()
    {
        UpdateValues();
        Debug.Log("clic");
    }

    public void UpdateValues()
    {
        if(m_name != nameInput.text)
        {
            Debug.Log("SaveHardData.json");
            SaveData data = new SaveData();
            data.nameText = nameInput.ToString();
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.dataPath + "/SaveHardData.json", json);
            PlayerPrefs.SetString(key_name, nameInput.text);
        }
        if (m_age != ageInput.text)
        {
            SaveData data = new SaveData();
            data.ageText = ageInput.ToString();
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.dataPath + "/SaveHardData.json", json);
            PlayerPrefs.SetString(key_age, ageInput.text);
        }
        if (m_city != cityInput.text)
        {
            SaveData data = new SaveData();
            data.cityText = cityInput.ToString();
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.dataPath + "/SaveHardData.json", json);
            PlayerPrefs.SetString(key_city, cityInput.text);
        }
        if (m_weight != weightInput.text)
        {
            SaveData data = new SaveData();
            data.weightText = weightInput.ToString();
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.dataPath + "/SaveHardData.json", json);
            PlayerPrefs.SetString(key_weight, weightInput.text);
        }      
    }
    
}
