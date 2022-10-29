using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public GameObject spherePrefab;
    public Slider scaleSlider;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AlphaSphere()
    {
        scaleValue.x = scaleSlider.value;
        scaleValue.y = scaleSlider.value;
        scaleValue.z = scaleSlider.value;

        spherePrefab.transform.localScale = scaleValue;
    }
