using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This script aim to rotate camera around central of model*/

public class CameraRotator : MonoBehaviour
{
    public float speed;


    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}