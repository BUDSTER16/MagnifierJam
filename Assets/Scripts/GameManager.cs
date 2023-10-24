using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public GameObject canvas;

    public Texture2D crosshair;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector2 cursorOffset = new Vector2(crosshair.width / 2, crosshair.height / 2);
        Cursor.SetCursor(crosshair, cursorOffset, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Debug.Log("PAUSED MF");
            canvas.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName: "TestArea");
    }

    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
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

    public void ResumeGame()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
    }    


}
