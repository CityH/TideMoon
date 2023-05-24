using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ContiuneGame()
    {
        Debug.Log("3进入游戏");
        var currentScene = SceneManager.GetActiveScene().name;//定义一个变量获得当前激活的场景的名字
        Debug.Log("获得当前场景名称"+currentScene);
        TransitionManager.GetInstance().Transition(currentScene,"Game");
        Debug.Log("进入下一个场景");
    }
    public void GoBackToMenu()
    {
        // Time.timeScale = 0;
        var currentScene = SceneManager.GetActiveScene().name;//定义一个变量获得当前场景的名字
        // string cu = SceneManager.GetActiveScene().name;
        TransitionManager.GetInstance().Transition(currentScene,"MainMenu");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));

    }
}
