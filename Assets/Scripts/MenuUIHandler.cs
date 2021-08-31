using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public InputField playerName;

    public void StartGame()
    {
        if (playerName.text.Length > 0)
        {
            GameManager.Instance.PlayerName = playerName.text;
        }
        else
        {
            GameManager.Instance.PlayerName = "noname";
        }

        SceneManager.LoadScene("main");
    }

    public void Exit()
    {
     
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
