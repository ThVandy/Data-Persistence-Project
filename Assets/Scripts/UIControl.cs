using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public InputField playerNameInput;

    public void Exit()
    {
        MenuManager.Instance.SaveBestScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void GameStart()
    {
        MenuManager.Instance.playerName = playerNameInput.text;
        SceneManager.LoadScene(1);
    }
}

