using System;
using UnityEngine;

public enum EjesRotacion { MouseX, MouseY, MouseXY }

public class RotationController : MonoBehaviour
{
    [SerializeField] public float maxRotacionY = 180;
    [SerializeField] public float minRotacionY = -180;
    [SerializeField] public float velocidadRotacion = 320;
    public EjesRotacion modoRotacion = EjesRotacion.MouseX;

    void Start()
    {
        Debug.Log("Posicion inicial: " + transform.position);
        Debug.Log("Posicion final: " + transform.rotation);
    }

    void Update()
    {
        //transform.Rotate(incRotacionX,incRotacionY,0,Space.Self);

        float incRotacionX = -Input.GetAxis("Mouse Y") * velocidadRotacion * Time.deltaTime; //mov arriba abajo
        float incRotacionY = Input.GetAxis("Mouse X") * velocidadRotacion * Time.deltaTime; //mov derecha izquierda

        incRotacionX = Mathf.Clamp(incRotacionX, minRotacionY, maxRotacionY);

        Vector3 movMouse = new();

        switch (modoRotacion)
        {
            case EjesRotacion.MouseX: //derecha izquierda
                movMouse = new Vector3(0, incRotacionY, 0);
                break;
            case EjesRotacion.MouseY: //arriba abajo
                movMouse = new Vector3(incRotacionX, 0, 0);
                break;
            case EjesRotacion.MouseXY:
                movMouse = new Vector3(incRotacionX, incRotacionY, 0);
                break;
        }

        transform.localEulerAngles += movMouse;

    }
}
