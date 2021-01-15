using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("GameOverScene");
    }
    public void LoadStartMenu()
    {
        //First Scene
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        //Game Scene
        SceneManager.LoadScene("CarGame");
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator WinnerSceneWaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("WinScene");
    }

    public void LoadWinnerScene()
    {
        StartCoroutine(WinnerSceneWaitAndLoad());
    }
}
