using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Exercise7 : MonoBehaviour
{
    public GameObject spherePrefab;
    private Material sphereMat;

    void Start()
    {
        sphereMat = spherePrefab.GetComponent<Renderer>().material;
    }

    public void AlphaSphere(float alphaValue)
    {
        //It changes the alpha without touching the RGB properties created for the material
        sphereMat.color = new Vector4(sphereMat.color.r, sphereMat.color.g, sphereMat.color.b, alphaValue);
    }
}
