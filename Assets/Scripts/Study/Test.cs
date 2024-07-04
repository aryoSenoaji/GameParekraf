using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        Debug.Log("On Enable");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    private void OnDisable()
    {
        Debug.Log("On Disable");
    }

    private void OnDestroy()
    {
        Debug.Log("On Destroy");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("On Application Quit");
    }
}
