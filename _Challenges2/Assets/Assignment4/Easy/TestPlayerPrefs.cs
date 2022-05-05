using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using TMPro;

/// <summary>
/// * create a new project with a sign-up
/// * The page should ask: Name, Age, City, Weight
/// * use PlayerPrefabs to store data
/// </summary>

public class TestPlayerPrefs : MonoBehaviour
{
    /*
    // Input Fields
    [SerializeField] private GameObject nameText;
    [SerializeField] private GameObject ageText;
    [SerializeField] private GameObject cityText;
    [SerializeField] private GameObject weightText;

    // values 
    [SerializeField] private TextMeshProUGUI nameInput;
    [SerializeField] private TextMeshProUGUI ageInput;
    [SerializeField] private TextMeshProUGUI cityInput;
    [SerializeField] private TextMeshProUGUI weightInput;

    // keys
    private string NameKey;
    private string AgeKey;
    private string CityKey;
    private string WeightKey;

    public void Start()
    {
        Keys();
    }

    // Start is called before the first frame update
    public void Keys()
    {
        if (PlayerPrefs.HasKey("NameKey"))
        {
            Debug.Log(nameInput.text);
            string NameInput = PlayerPrefs.GetString("nameKey");
            NameInput = NameKey.ToString();
            //Debug.Log(PlayerPrefs.GetString(NameKey));
        }
        if (PlayerPrefs.HasKey("CityKey"))
        {
            Debug.Log(cityInput.text);
            string city = PlayerPrefs.GetString("cityInput");
            cityInput.text = city.ToString();
            Debug.Log(PlayerPrefs.GetString(CityKey));
        }

        if(PlayerPrefs.HasKey("AgeKey"))
        {
            Debug.Log(ageInput.text);
            string age = PlayerPrefs.GetString("ageInput");
            ageInput.text = age.ToString();
            Debug.Log(PlayerPrefs.GetString(AgeKey));
        }

        if (PlayerPrefs.HasKey("WeightKey"))
        {
            Debug.Log(weightInput.text);
            string weight = PlayerPrefs.GetString("weightInput");
            weightInput.text = weight.ToString();
            Debug.Log(PlayerPrefs.GetString(WeightKey));
        }           
    }

    public void StoreKey()
    {
        NameInput.text = nameText.GetComponent<TextMeshProUGUI>().text;
        nameInput.GetComponent<TextMeshProUGUI>().text = NameKey.ToString();

        CityKey = cityText.GetComponent<TextMeshProUGUI>().text;
        cityInput.GetComponent<TextMeshProUGUI>().text = CityKey.ToString();

        AgeKey = ageText.GetComponent<TextMeshProUGUI>().text;
        ageInput.GetComponent<TextMeshProUGUI>().text = AgeKey.ToString();

        WeightKey = weightText.GetComponent<TextMeshProUGUI>().text;
        weightInput.GetComponent<TextMeshProUGUI>().text = WeightKey.ToString();
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("NameKey", NameKey);
        Debug.Log(NameKey + "NameSafe");

        PlayerPrefs.SetString("CityKey", CityKey);
        Debug.Log(CityKey + "CitySafe");


        PlayerPrefs.SetString("AgeKey", AgeKey);
        Debug.Log(AgeKey + "AgeSafe");

        PlayerPrefs.SetString("WeightKey", WeightKey);
        Debug.Log(WeightKey + "WeightSafe");

    }
}
    */

    // didn't work out
    /*
        public GameObject name;
        public GameObject age;
        public GameObject city;
        public GameObject weight;

        private void Update()
        {
            NameKey = name.GetComponent<InputField>().text;
            AgeKey = age.GetComponent<InputField>().text;
            CityKey = city.GetComponent<InputField>().text;
            WeightKey = weight.GetComponent<InputField>().text;
        }

            Debug.Log(cityInput.text);
            PlayerPrefs.SetString(CityKey, cityInput.text);
            Debug.Log(PlayerPrefs.GetString(CityKey));

            Debug.Log(ageInput.text);
            PlayerPrefs.SetInt(AgeKey, Int32.Parse(ageInput.text));
            Debug.Log(PlayerPrefs.GetInt(AgeKey).ToString());

            Debug.Log(weightInput.text);
            PlayerPrefs.SetFloat(WeightKey, float.Parse(weightInput.text));
            Debug.Log(PlayerPrefs.GetFloat(WeightKey).ToString());
    */

}