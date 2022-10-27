using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise4 : MonoBehaviour
{
    public Slider scaleSlider;
    private Vector3 scaleValue;

    public void ScaleSphere()
    {
        scaleValue.x = scaleSlider.value;
        scaleValue.y = scaleSlider.value;
        scaleValue.z = scaleSlider.value;

        transform.localScale = scaleValue;
    }
}
