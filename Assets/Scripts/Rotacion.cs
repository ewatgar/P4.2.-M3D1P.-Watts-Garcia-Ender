using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    [SerializeField] private float _velocidadAngular = 100;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0,_velocidadAngular*Time.deltaTime,0);
    }
}
