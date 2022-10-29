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
        exercise10Script.UpdatePoints(points);
        Destroy(gameObject);
    }
}
