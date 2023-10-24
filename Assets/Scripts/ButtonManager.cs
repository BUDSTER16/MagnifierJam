using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button btnPlay, btnLevels, btnQuit; 


    void Start()
    {
        btnPlay.onClick.AddListener(playOnClick);
        btnLevels.onClick.AddListener(levelsOnClick);
        btnQuit.onClick.AddListener(quitOnClick);
    }

    void playOnClick()
    {
        GameManager.Instance.StartGame();
    }
    void levelsOnClick()
    {
        GameManager.Instance.LevelSelecter();
    }
    void quitOnClick()
    {
        GameManager.Instance.QuitGame();
    }
   
}
