using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsButtonMgr : MonoBehaviour
{

    public Button btnTutorial, btnLvl1, btnLvlBeams, btnLvlBounce, btnLvlSPEED, btnLvlFinal, btnBack;

    // Start is called before the first frame update
    void Start()
    {
        btnTutorial.onClick.AddListener(tutorialOnClick);
        btnLvl1.onClick.AddListener(lvl1OnClick);
        btnLvlBeams.onClick.AddListener(beamsOnClick);
        btnLvlBounce.onClick.AddListener(bounceOnClick);
        btnLvlSPEED.onClick.AddListener(SPEEDOnClick);
        btnLvlFinal.onClick.AddListener(finalOnClick);
        btnBack.onClick.AddListener(backOnClick);

    }

    public void tutorialOnClick()
    {
        GameManager.Instance.StartGame();
    }

    public void lvl1OnClick()
    {
        GameManager.Instance.Level1();
    }

    public void beamsOnClick()
    {
        GameManager.Instance.LevelBeams();
    }

    public void bounceOnClick()
    {
        GameManager.Instance.LevelBounce();
    }

    public void SPEEDOnClick()
    {
        GameManager.Instance.LevelSpeed();
    }

    public void finalOnClick()
    {
        GameManager.Instance.LevelFinal();
    }

    public void backOnClick()
    {
        GameManager.Instance.Back();
    }



}
