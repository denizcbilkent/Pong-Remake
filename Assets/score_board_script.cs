using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_board_script : MonoBehaviour
{
    public int playerScore;
    public Text scoreBoardText;

    [ContextMenu("AddScore")]
    public void AddScore()
    {
        playerScore++;
        scoreBoardText.text = playerScore.ToString();
    }

}
