using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EliSolutionEasy : MonoBehaviour
{
    //Input fields
    [SerializeField] private GameObject m_inputName;
    [SerializeField] private GameObject m_inputCity;
    [SerializeField] private GameObject m_inputAge;
    [SerializeField] private GameObject m_inputWeight;

    //where the saved  information will be stored -> VALUE
    [SerializeField] private TextMeshProUGUI m_nameText;
    [SerializeField] private TextMeshProUGUI m_ageText;
    [SerializeField] private TextMeshProUGUI m_weightText;
    [SerializeField] private TextMeshProUGUI m_cityText;

    //information variables gathered
    private string m_name;
    private string m_city;
    private string m_age;
    private string m_weight;

    private void Awake()//If a name had been saved, will retrieve and make visible the saved fields
    {
        if (PlayerPrefs.HasKey("name"))//check to see if a name was saved and if so load upon play
        {
            string age = PlayerPrefs.GetString("age");
            m_ageText.text = age.ToString();
            m_age = age;
            string weight = PlayerPrefs.GetString("weight");
            m_weightText.text = weight.ToString();
            m_weight = weight;
            string name = PlayerPrefs.GetString("name");
            m_nameText.text = name.ToString();
            m_name = name;
            string city = PlayerPrefs.GetString("city");
            m_cityText.text = city.ToString();
            m_city = city;
        }
    }
    public void StoreName()
    //upon clicking submit button defines the field values to feed info for application quit variables
    //add click trigger to submit button
    {
        m_age = m_inputAge.GetComponent<TextMeshProUGUI>().text;
        m_ageText.GetComponent<TextMeshProUGUI>().text = m_age.ToString();
        m_weight = m_inputWeight.GetComponent<TextMeshProUGUI>().text;
        m_weightText.GetComponent<TextMeshProUGUI>().text = m_weight.ToString();
        m_city = m_inputCity.GetComponent<TextMeshProUGUI>().text;
        m_cityText.GetComponent<TextMeshProUGUI>().text = m_city;
        m_name = m_inputName.GetComponent<TextMeshProUGUI>().text;
        m_nameText.GetComponent<TextMeshProUGUI>().text = m_name;
    }
    private void OnApplicationQuit()//player prefs approach. Save upon quite
    {
        PlayerPrefs.SetString("name", m_name);//setsString upon quit with  m_nameTransfer.name as string
        Debug.Log(m_name);
        PlayerPrefs.SetString("city", m_city);//setsString upon quit with  m_nameTransfer.name as string
        Debug.Log(m_city);
        PlayerPrefs.SetString("age", m_age.ToString());//sets score upon quiting with m_highScore as value
        Debug.Log(m_age);
        PlayerPrefs.SetString("weight", m_weight.ToString());//sets score upon quiting with m_highScore as value
        Debug.Log(m_weight);
    }
}
