using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    public GameObject GameOverScreen;
    public void ResetarCenaAtual()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ShowGameOverScreen()
    {
        GameOverScreen.SetActive(true);
    }
}
