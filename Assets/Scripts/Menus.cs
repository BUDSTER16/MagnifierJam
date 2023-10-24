using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName: "TestArea");
    }

    public void QuitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
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

}
