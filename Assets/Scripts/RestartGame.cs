using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Game"); // Cambia "GameScene" por el nombre de tu escena de juego principal
    }
}

