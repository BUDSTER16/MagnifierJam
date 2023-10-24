using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    public Button btnMenu, btnResume;


    void Start()
    {
        btnResume.onClick.AddListener(resumeOnClick);
        btnMenu.onClick.AddListener(menuOnClick);
    }

    void resumeOnClick()
    {
        GameManager.Instance.ResumeGame();
    }
    void menuOnClick()
    {
        GameManager.Instance.Back();
    }
}
