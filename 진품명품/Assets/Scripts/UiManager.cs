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
    public void selectStartButton(string scene)
    {
        SceneMgr.Load((SceneMgr.Scene)(int.Parse(scene) + 2));
        SceneMgr.LoaderCallback();
    }
    #endregion

    #region Ingame
    public void EndUI()
    {
        scoreText.rectTransform.anchorMax = new Vector2(.5f, .5f);
        scoreText.rectTransform.anchorMin = new Vector2(.5f, .5f);
    }
    //

    //
    public void pauseButton()
    {
        Time.timeScale = 0;
        pausePopUp.SetActive(true);
    }
    public void runningButton()
    {
        Time.timeScale = 1;
        pausePopUp.SetActive(false);
    }
    public void restartButton()
    {
        runningButton();
        //SceneMgr.Load(SceneMgr.Scene.IngameScene1);
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
