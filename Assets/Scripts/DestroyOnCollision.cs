using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escenas

public class DestroyOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Verificar si el jugador colisiona con un enemigo
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("Defeat"); // Cambia "DefeatScene" por el nombre de tu escena de derrota
        }

        // Verificar si el jugador colisiona con una moneda
        if (collision.gameObject.CompareTag("Coin"))
        {
            SceneManager.LoadScene("Victory"); // Cambia "VictoryScene" por el nombre de tu escena de victoria
        }
    }
}




