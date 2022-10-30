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
        lightToggle.isOn = false;
    }

    public void SwitchToggle()
    {
        if(lightToggle.isOn == true)
        {
            pointLight.SetActive(true);
        }
        else
        {
            pointLight.SetActive(false);
        }
    }
}
