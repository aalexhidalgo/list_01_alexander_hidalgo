using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    public GameObject capsulePrefab;
    public Vector3[] posArray;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            //In each position of the array will appear a capsule
            foreach(Vector3 pos in posArray)
            {
                Instantiate(capsulePrefab, pos, capsulePrefab.transform.rotation);
            }
        }
    }
}
