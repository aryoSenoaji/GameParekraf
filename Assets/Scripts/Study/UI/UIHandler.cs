using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private Rotating rotator;

    private void Start()
    {
        if (rotator == null)
        {
            Debug.LogError("Rotator is not assigned!");
        }
    }

    public void OnLeftButtonDown()
    {
        if (rotator != null)
        {
            rotator.OnLeftButtonDown();
        }
    }

    public void OnRightButtonDown()
    {
        if (rotator != null)
        {
            rotator.OnRightButtonDown();
        }
    }

    public void OnButtonUp()
    {
        if (rotator != null)
        {
            rotator.OnButtonUp();
        }
    }
}
