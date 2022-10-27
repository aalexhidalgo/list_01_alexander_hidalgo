using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    private float xLimit = 6.6f;
    private float yLimit = 3.5f;
    private Vector3 pos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            pos = new Vector3 (Random.Range(-xLimit, xLimit), Random.Range (-yLimit, yLimit), 0);
            transform.position = pos;
        }
    }
}
