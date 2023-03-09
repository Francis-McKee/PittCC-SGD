using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject InGamePanel;
    public GameObject GameOverPanel;

    public Text scoreText;
    public Text countdownText;
    public Text GameOverText;

    public float countdownTime;
    public float countdownStartTime;

    public int score;
    public bool gameIsOver;

    // Start is called before the first frame update
    void Start()
    {
        gameIsOver = false;
        GameOverPanel.SetActive(gameIsOver);
        countdownTime = countdownStartTime;
        score = 0;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownTime > 0.0f)
        {
            countdownTime -= Time.deltaTime;
        } else
        {
            gameIsOver = true;
            GameOverPanel.SetActive(gameIsOver);
            GameOverText.text = "Game Over\n" + "Final Score: " + score;
            countdownTime = 0.0f;
        }
        countdownText.text = countdownTime.ToString();
        scoreText.text = "Score: " + score.ToString();
    }

    public void HandleButtonClick()
    {
        Debug.Log("HandleButtonClick");
        if (!gameIsOver)
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }

    public void HandlePlayAgainButton()
    {
        Debug.Log("HandlePlayAgainButton");

        countdownTime = countdownStartTime;
        score = 0;
        gameIsOver = false;
        GameOverPanel.SetActive(gameIsOver);
    }
}
