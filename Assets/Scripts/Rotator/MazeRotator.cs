using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRotator : MonoBehaviour
{
    // input for rotation maze speed
    [SerializeField] private float rotationSpeed = 50;

    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    private void Update()
    {
        if (isMovingLeft)
        {
            MoveLeft();
        }
        if (isMovingRight)
        {
            MoveRight();
        }
    }

    private void MoveLeft()
    {
        transform.Rotate(0, 0, Time.deltaTime * rotationSpeed);
    }

    private void MoveRight()
    {
        transform.Rotate(0, 0, -Time.deltaTime * rotationSpeed);
    }

    // event trigger function ketika tombol ditekan
    public void OnLeftButtonDown() => isMovingLeft = true;
    public void OnRightButtonDown() => isMovingRight = true;

    public void OnButtonUp()
    {
        isMovingLeft = false;
        isMovingRight = false;
    }
}
