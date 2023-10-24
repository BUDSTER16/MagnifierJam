using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{


    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            Pause();
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
        }
    }


    public void StartGame()
    {
        SceneManager.LoadScene(sceneName: "TestArea");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LevelSelecter()
    {
        SceneManager.LoadScene(sceneName: "LevelSelect");
    }

    public void Back()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }

    public void Level1()
    {
        SceneManager.LoadScene(sceneName: "Level1");
    }

    public void LevelBeams()
    {
        SceneManager.LoadScene(sceneName: "LevelBeams");
    }

    public void LevelBounce()
    {
        SceneManager.LoadScene(sceneName: "LevelBounce");
    }

    public void LevelSpeed()
    {
        SceneManager.LoadScene(sceneName: "LevelSPEED");
    }

    public void LevelFinal()
    {
        SceneManager.LoadScene(sceneName: "LevelFINAL");
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

}
