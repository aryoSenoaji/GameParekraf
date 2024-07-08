using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private MazeRotator mazeRotator;

    private void Start()
    {
        if (mazeRotator == null)
        {
            Debug.LogError("Rotator is not assigned!");
        }
    }

    public void OnLeftButtonDown()
    {
        if (mazeRotator != null)
        {
            mazeRotator.OnLeftButtonDown();
        }
    }

    public void OnRightButtonDown()
    {
        if (mazeRotator != null)
        {
            mazeRotator.OnRightButtonDown();
        }
    }

    public void OnButtonUp()
    {
        if (mazeRotator != null)
        {
            mazeRotator.OnButtonUp();
        }
    }
}
