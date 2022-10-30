using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private int points = 1;
    private Exercise10 exercise10Script;

    void Start()
    {
        exercise10Script = FindObjectOfType<Exercise10>();
    }

    public void OnMouseDown()
    {
        //Everytime a pumpkin is clicked a point will be added to the counter and the pumpkin will disappear
        exercise10Script.UpdatePoints(points);
        Destroy(gameObject);
    }
}
