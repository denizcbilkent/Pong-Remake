using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManagerScript : MonoBehaviour
{
    private int player1Score;
    private int player2Score;
    public Text scoreBoardText1;
    public Text scoreBoardText2;
    public ball_script ball;
    public player_script player1;
    public player2_script player2;

    public void Player1Scores()
    {
        player1Score++;
        scoreBoardText1.text = player1Score.ToString();
        ball.Reset();
        player2.Reset();
        player1.Reset();
    }

    public void Player2Scores()
    {
        player2Score++;
        scoreBoardText2.text = player2Score.ToString();
        player2.Reset();
        player1.Reset();
        ball.Reset();
    }

    public void MainMenuFunc()
    {
        player1Score = 0;
        scoreBoardText1.text = player1Score.ToString();
        player2Score = 0;
        scoreBoardText2.text = player2Score.ToString();
        player2.Reset();
        player1.Reset();
        ball.Reset();
        SceneManager.LoadScene("Menu Scene", LoadSceneMode.Single);
    }


}
