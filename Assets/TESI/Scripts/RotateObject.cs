using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private Vector3 inputStartPos;
    private Vector3 inputEndPos;
    private float rotationSpeed = 180.0f; // Velocità di rotazione

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            inputStartPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            inputEndPos = Input.mousePosition;
            Vector3 inputDelta = inputEndPos - inputStartPos;
            float rotationAmount = inputDelta.x * rotationSpeed * Time.deltaTime;

            // Ruota solo intorno all'asse Y
            transform.Rotate(Vector3.up, rotationAmount);

            inputStartPos = inputEndPos;
        }
        else if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                inputStartPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                inputEndPos = touch.position;
                Vector3 inputDelta = inputEndPos - inputStartPos;
                float rotationAmount = inputDelta.x * rotationSpeed * Time.deltaTime;

                // Ruota solo intorno all'asse Y
                transform.Rotate(Vector3.up, rotationAmount);

                inputStartPos = inputEndPos;
            }
        }
    }
}