using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class Assi4HardPupil : MonoBehaviour
{
    public class Assi4Hard : MonoBehaviour
    {
        public static Assi4Hard s_instance;

        // Values
        [SerializeField] private TMP_InputField nameInputPupil;
        [SerializeField] private TMP_InputField ageInputPupil;
        [SerializeField] private TMP_InputField cityInputPupil;
        [SerializeField] private TMP_InputField weightInputPupil;

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
            if (s_instance == null)
            {
                s_instance = this;
            }
            else
            {
                Debug.LogError("tooManySingleton, Mister");
            }

            if (File.Exists(Application.dataPath + "/SaveHardData.json"))
            {
                // check if key exists already and if so, take it and show it
                m_name = PlayerPrefs.GetString(key_name);
                nameInputPupil.text = m_name.ToString();
                Debug.Log(m_name);

                m_age = PlayerPrefs.GetString(key_age);
                ageInputPupil.text = m_age.ToString();
                Debug.Log(m_age);

                m_city = PlayerPrefs.GetString(key_city);
                cityInputPupil.text = m_city.ToString();
                Debug.Log(m_city);

                m_weight = PlayerPrefs.GetString(key_weight);
                weightInputPupil.text = m_weight.ToString();
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
            if (m_name != nameInputPupil.text)
            {
                Debug.Log("SaveHardData.json");
                SaveData data = new SaveData();
                data.nameText = nameInputPupil.ToString();
                string json = JsonUtility.ToJson(data);
                File.WriteAllText(Application.dataPath + "/SaveHardData.json", json);
                PlayerPrefs.SetString(key_name, nameInputPupil.text);
            }
            if (m_age != ageInputPupil.text)
            {
                SaveData data = new SaveData();
                data.ageText = ageInputPupil.ToString();
                string json = JsonUtility.ToJson(data);
                File.WriteAllText(Application.dataPath + "/SaveHardData.json", json);
                PlayerPrefs.SetString(key_age, ageInputPupil.text);
            }
            if (m_city != cityInputPupil.text)
            {
                SaveData data = new SaveData();
                data.cityText = cityInputPupil.ToString();
                string json = JsonUtility.ToJson(data);
                File.WriteAllText(Application.dataPath + "/SaveHardData.json", json);
                PlayerPrefs.SetString(key_city, cityInputPupil.text);
            }
            if (m_weight != weightInputPupil.text)
            {
                SaveData data = new SaveData();
                data.weightText = weightInputPupil.ToString();
                string json = JsonUtility.ToJson(data);
                File.WriteAllText(Application.dataPath + "/SaveHardData.json", json);
                PlayerPrefs.SetString(key_weight, weightInputPupil.text);
            }
        }

    }
}
