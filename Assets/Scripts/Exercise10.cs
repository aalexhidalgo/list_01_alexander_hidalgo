using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise10 : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    private int pointsCounter;

    //Surprise
    public TextMeshProUGUI gameText;
    public GameObject finalPumpkin;

    //This will update the text with the amount of points scored
    public void UpdatePoints(int points)
    {
        pointsCounter += points;
        pointsText.text = $"{pointsCounter}";

        //Surprise
        if(pointsCounter == 30)
        {
            StartCoroutine(Win());
        }
    }

    //Surprise
    private IEnumerator Win()
    {
        yield return new WaitForSeconds(0.5f);
        gameText.text = "¡YOU WIN!";
        finalPumpkin.SetActive(true);
    }
}
