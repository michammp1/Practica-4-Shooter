﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Disparo : MonoBehaviour
{


    public Transform arma;
    public Transform disparo;
    public Transform Camera;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(disparo, arma.position, Camera.rotation);
        }

    }
}
