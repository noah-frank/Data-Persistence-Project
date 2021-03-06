using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;


public class HandleMenuUI : MonoBehaviour
{

    public TextMeshProUGUI PlayerNameInput;


    public void StartGame(){
        HandlePlayerData.Instance.PlayerName = PlayerNameInput.text;
        SceneManager.LoadScene("main");
    }

    public void ExitGame(){
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }





}
