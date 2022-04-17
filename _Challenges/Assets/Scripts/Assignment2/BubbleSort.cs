using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BubbleSort : MonoBehaviour
{
    [SerializeField]  private int[] rand;
    public Text text1;
    public Text text2;

    // Start is called before the first frame update
    void Start()
    {
        rand = new int[10];
        text1.text = "";
        text2.text = "";

        for (int z = 0; z < 10; z++)
        {
            rand[z] = Random.Range(0, 100);
            text1.text += " " + rand[z];
        }

        bubbleSort(rand);

    }

    private void bubbleSort(int[] array)
    {
        int Remember = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j+1])
                {
                    Remember = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = Remember;
                }
            }
        }

        for (int z = 0; z < array.Length; z++)
        {
            text2.text += " " + array[z];
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
