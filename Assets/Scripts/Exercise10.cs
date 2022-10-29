using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise10 : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    private int pointsCounter;

    private void OnMouseDown()
    {
        pointsCounter++;
        pointsText.text = $"{pointsCounter}";
    }
}
