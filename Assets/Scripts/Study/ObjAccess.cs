using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjAccess : MonoBehaviour
{

    [SerializeField]
    private Transform _transformSquare;

    [SerializeField]
    private GameObject _square;
    
    private void Start()
    {
        Debug.Log(_square.name);
        Debug.Log(_square.tag);
    }  
}
