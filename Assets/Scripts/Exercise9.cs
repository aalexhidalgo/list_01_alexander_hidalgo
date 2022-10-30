using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise9 : MonoBehaviour
{
    public GameObject pointLight;
    public Toggle lightToggle;

    void Awake()
    {
        //At the beginning the light it's off
        lightToggle.isOn = false;
    }

    public void SwitchToggle()
    {
        //If it's on, the point light will be on
        if(lightToggle.isOn == true)
        {
            pointLight.SetActive(true);
        }
        //If it's off the point light will be off
        else
        {
            pointLight.SetActive(false);
        }
    }
}
