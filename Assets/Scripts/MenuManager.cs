using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public InputField playerNameInput;
    public string playerName;
    public int BestScore;

 

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }


        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public void GameStart()
    {
        playerName = playerNameInput.text;
        SceneManager.LoadScene(1);
    }



   
}
