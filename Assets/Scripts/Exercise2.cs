using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise2 : MonoBehaviour
{
    public int number;
    public TextMeshProUGUI numberText;
    public TextMeshProUGUI resultText;

    public GameObject startText;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //A warning text before display your number on the screen
            startText.SetActive(false);
            OddEven();
        }
    }

    public void OddEven()
    {
        //It shows on the screen the number and if it's odd or even
        if (number % 2 == 0)
        {            
            numberText.text = number.ToString();
            resultText.text = "Is even";
        }
        else
        {
            numberText.text = number.ToString();
            resultText.text = "Is odd";
        }
    }
}
