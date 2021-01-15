using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{

    int score = 0;
    // Start is called before the first frame update
    void Awake()
    {
        SetUpSingleton();
    }

    // Update is called once per frame
    private void SetUpSingleton()
    {
        int numberOfGameSessions = FindObjectsOfType<GameSession>().Length;

        if (numberOfGameSessions > 1)
        {
            Destroy(gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }


    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public void ProccessScore()
    {
        if (score >= 100)
        {
            Win();
        }
    }

    private void Win()
    {
        FindObjectOfType<Level>().LoadWinnerScene();
    }
}
