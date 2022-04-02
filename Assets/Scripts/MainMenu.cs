using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject ball;
    void Update()
    {
        if (!ball.activeSelf && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Activating ball");
            ball.SetActive(true);
        }
    }
    public void PlayGame(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
