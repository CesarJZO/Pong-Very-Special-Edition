using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject ball;
    public void PlayGame(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ActiveBall()
    {
        if (ball != null && !ball.activeSelf)
            ball.SetActive(true);
    }
}
