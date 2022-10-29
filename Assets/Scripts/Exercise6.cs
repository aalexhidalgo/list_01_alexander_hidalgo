using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    public GameObject cylinderPrefab;
    public Color[] colors;

    void Start()
    {
        //At the beginning the default one will be the red color, as it's the first option in the dropdown
        ColorSelection(0);
    }

    public void ColorSelection(int selected)
    {
        cylinderPrefab.GetComponent<Renderer>().material.color = colors[selected];
    }
}
