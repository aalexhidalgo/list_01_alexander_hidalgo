using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise2 : MonoBehaviour
{
    public int number;
    public TextMeshProUGUI numberOnScreenText;
    public TextMeshProUGUI numberText;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            OddEven();
        }
    }

    public void OddEven()
    {
        if (number % 2 == 0)
        {
            //It shows on the screen the number and if it's odd or even
            numberOnScreenText.text = number.ToString();
            numberText.text = "Is odd";
        }
        else
        {
            numberOnScreenText.text = number.ToString();
            numberText.text = "Is even";
        }
    }
}
