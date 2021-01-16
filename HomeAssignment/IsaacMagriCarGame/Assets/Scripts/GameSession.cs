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


        if (FindObjectOfType<Player>().GetHealth() > 0 && score < 100)
        {
            score += scoreValue;
        }

        if (score >= 100)
        {
            Win();
        }


    }


    public void ResetGame()
    {
        Destroy(gameObject);
    }


    private void Win()
    {
        FindObjectOfType<Level>().LoadWinnerScene();
    }
}
