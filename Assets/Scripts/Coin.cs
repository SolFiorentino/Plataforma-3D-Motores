using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidad de rotaci�n

    void Update()
    {
        // Girar el objeto alrededor del eje Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}


