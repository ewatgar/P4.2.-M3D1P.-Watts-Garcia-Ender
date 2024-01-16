using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAnimation : MonoBehaviour
{
    [SerializeField] private GameObject _sol;
    [SerializeField] private GameObject _mercurio;
    [SerializeField] private GameObject _venus;
    [SerializeField] private GameObject _tierra;
    [SerializeField] private GameObject _marte;
    [SerializeField] private GameObject _jupiter;
    [SerializeField] private GameObject _saturno;
    [SerializeField] private GameObject _urano;
    [SerializeField] private GameObject _neptuno;

    

    void Start()
    {
        
    }

    void Update()
    {
        /*DESACTIVADO
        float _velocidadAngular = 100;
        GameObject[] listaPlanetas = {_mercurio,_venus,_tierra,_marte,_jupiter,_saturno,_urano,_neptuno};

        foreach (GameObject planeta in listaPlanetas){
            planeta.transform.Rotate(0,_velocidadAngular*Time.deltaTime,0);
            _velocidadAngular-=10;
        }

        _sol.transform.Rotate(0,30*Time.deltaTime,0);
        */
    }
}
