using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Exercise7 : MonoBehaviour
{
    public GameObject spherePrefab;
    private Material sphereMat;
    public Slider alphaSlider;

    void Start()
    {
        //At the beginnig, we set the value to 1 to see the sphere       
        sphereMat = spherePrefab.GetComponent<Renderer>().material;
        alphaSlider.value = 1;
    }

    public void AlphaSphere(float alphaValue)
    {
        //It changes the alpha without touching the RGB properties created for the material
        sphereMat.color = new Vector4(sphereMat.color.r, sphereMat.color.g, sphereMat.color.b, alphaValue);
    }
}
