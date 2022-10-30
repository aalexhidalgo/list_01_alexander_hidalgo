using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public GameObject cubePrefab;
    private float xLimit = 8.1f;
    private float yLimit = 4.35f;
    private Vector3 pos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //We randomize a new position everytime the "return" key is pressed that will take instantly the cube
            pos = new Vector3 (Random.Range(-xLimit, xLimit), Random.Range (-yLimit, yLimit), 0);
            cubePrefab.transform.position = pos;
        }
    }
}
