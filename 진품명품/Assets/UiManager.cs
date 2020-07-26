using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject pausePopUp;

    #region Title
    public void titleStartButton()
    {
        SceneMgr.Load(SceneMgr.Scene.SelectScene);
        SceneMgr.LoaderCallback();
    }
    #endregion

    #region Select
    public void selectStartButton()
    {
        SceneMgr.Load(SceneMgr.Scene.IngameScene);
        SceneMgr.LoaderCallback();
    }
    #endregion

    #region Ingame
    public void pauseButton()
    {
        Time.timeScale = 0;
        pausePopUp.SetActive(true);
    }
    public void runningButton()
    {
        Time.timeScale = 1;
        pausePopUp.SetActive(false) ;
    }
    public void restartButton()
    {
        runningButton();
        SceneMgr.Load(SceneMgr.Scene.IngameScene);
        SceneMgr.LoaderCallback();
    }
    public void menuButton()
    {
        runningButton();
        SceneMgr.Load(SceneMgr.Scene.SelectScene);
        SceneMgr.LoaderCallback();
    }
    #endregion
}
