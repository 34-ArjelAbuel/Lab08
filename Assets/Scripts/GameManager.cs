using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;
    private int scoreCount;
    private int totalScore = 30;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    private void Update()
    {
        WinCondition();
    }

    public void AddScore()
    {
        scoreCount++;
        scoreText.text = "Score: " + scoreCount;
    }
    public void WinCondition()
    {
        if(scoreCount >= totalScore)
        {
            SceneManager.LoadScene("GameWin");
        }
    }
}
