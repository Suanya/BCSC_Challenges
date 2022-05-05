using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// * create a new project with a sign-up
/// * The page should ask: Name, Age, City, Weight
/// * use PlayerPrefabs to store data
/// </summary>

public class Assi4Easy : MonoBehaviour
{   
    // Values
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField ageInput;
    [SerializeField] private TMP_InputField cityInput;
    [SerializeField] private TMP_InputField weightInput;

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

    private void OnApplicationQuit()
    {
        UpdateValues();
    }

    public void UpdateValues()
    {
        PlayerPrefs.SetString(key_name, nameInput.text);
        PlayerPrefs.SetString(key_age, ageInput.text);
        PlayerPrefs.SetString(key_city, cityInput.text);
        PlayerPrefs.SetString(key_weight, weightInput.text);
    }
}
