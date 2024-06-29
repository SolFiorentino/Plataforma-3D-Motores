using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float moveSpeed = 2f; // Velocidad de movimiento lateral
    public float leftBound = -10f; // Límite izquierdo
    public float rightBound = 10f; // Límite derecho

    private bool moveRight = false; // Indicador de dirección de movimiento, comienza moviéndose hacia la izquierda

    void Update()
    {
        MoveHorizontally();
    }

    void MoveHorizontally()
    {
        // Determinar la dirección del movimiento y mover al enemigo
        if (moveRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // Cambiar la dirección al llegar a los límites
        if (transform.position.x >= rightBound)
        {
            moveRight = false;
        }
        else if (transform.position.x <= leftBound)
        {
            moveRight = true;
        }
    }
}

