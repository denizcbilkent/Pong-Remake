using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenu_script : MonoBehaviour
{

    // Single Player
    public void SingleButtonFunc()
    {
        player2_script.isPlayer = false;
        SceneManager.LoadScene("Main Scene", LoadSceneMode.Single);
    }

    // Update is called once per frame
    public void MultiButtonFunc()
    {
        player2_script.isPlayer = true;
        SceneManager.LoadScene("Main Scene", LoadSceneMode.Single);
    }

    public void QuitButtonFunc()
    {
        Application.Quit();
    }
}
