using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    private float tiempoTotal = 0;

    void Start()
    {
        print("Hola mundo");
    }

    void Update()
    {
        tiempoTotal += Time.deltaTime;

        if ((int) tiempoTotal != (int) (tiempoTotal - Time.deltaTime)){
            print((int)tiempoTotal);
        }
    }
}
