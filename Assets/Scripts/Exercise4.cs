using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise4 : MonoBehaviour
{
    public GameObject spherePrefab;
    public Slider scaleSlider;
    private Vector3 scaleValue;

    public void ScaleSphere()
    {
        //Every axis of the sphere is taked by the slider
        scaleValue.x = scaleSlider.value;
        scaleValue.y = scaleSlider.value;
        scaleValue.z = scaleSlider.value;

        //The scale will be applied by the value of the slider
        spherePrefab.transform.localScale = scaleValue;
    }
}
