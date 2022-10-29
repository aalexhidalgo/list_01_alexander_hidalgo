using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise10 : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    private int pointsCounter;

    public void UpdatePoints(int points)
    {
        pointsCounter += points;
        pointsText.text = $"{pointsCounter}";
    }
}
