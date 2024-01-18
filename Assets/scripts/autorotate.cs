using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autorotate : MonoBehaviour
{
    public float rotationSpeed = 10f; // Velocità di rotazione sull'asse Y

    private void Update()
    {
        // Calcola la quantità di rotazione in base al tempo e alla velocità di rotazione
        float rotationAmount = rotationSpeed * Time.deltaTime;
        
        // Ruota l'oggetto intorno all'asse Y
        transform.Rotate(Vector3.up, rotationAmount);
    }
}