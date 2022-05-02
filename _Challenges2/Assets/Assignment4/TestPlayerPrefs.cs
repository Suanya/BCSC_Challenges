using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class TestPlayerPrefs : MonoBehaviour
{
    // values 
    public string nameInput;
    public int ageInput;
    public string cityInput;
    public int weightInput;

    // keys
    string NameKey = "nameInput";
    string AgeKey = "ageInput";
    string CityKey = "cityInput";
    string WeightKey = "weightInput";

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString(NameKey, nameInput);
        Debug.Log(PlayerPrefs.GetString(NameKey));

        PlayerPrefs.SetInt(AgeKey, ageInput);
        Debug.Log(PlayerPrefs.GetInt(AgeKey).ToString());

        PlayerPrefs.SetString(CityKey, cityInput);
        Debug.Log(PlayerPrefs.GetString(CityKey));

        PlayerPrefs.SetInt(WeightKey, weightInput);
        Debug.Log(PlayerPrefs.GetInt(WeightKey).ToString());
    }
}

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
*/