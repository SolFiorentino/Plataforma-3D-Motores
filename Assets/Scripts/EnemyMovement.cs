using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // Velocidad de movimiento lateral
    public float leftBound = -10f; // L�mite izquierdo
    public float rightBound = 10f; // L�mite derecho

    private bool moveRight = true; // Indicador de direcci�n de movimiento

    void Update()
    {
        MoveHorizontally();
    }

    void MoveHorizontally()
    {
        // Determinar la direcci�n del movimiento y mover al enemigo
        if (moveRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // Cambiar la direcci�n al llegar a los l�mites
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





















