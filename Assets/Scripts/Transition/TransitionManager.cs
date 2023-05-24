using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//继承了单例模式
public class TransitionManager : SingletoAutoMono<TransitionManager>
{


    public void Transition(string from, string to)
    {
        Debug.Log(from);
        StartCoroutine(TransitionToScene(from, to));
        Debug.Log(to);

    }

    //协程方法，卸载当前场景，加载下个场景
    private IEnumerator TransitionToScene(string from, string to)
    {//这是调用了using UnityEngine.SceneManagement;才能调用SceneManager。
     //SceneManager是库自带的
        if (from != "Persistent")
            yield return SceneManager.UnloadSceneAsync(from);
        //注意，这是添加 Addtive
        yield return SceneManager.LoadSceneAsync(to, LoadSceneMode.Additive);
        //此时加载了两个场景（一个是永存的场景present，还有一个是加载的）
        //将SceneManager中的场景数量（2）-1，集合嘛，得到新加载的场景。
        //新加载的场景会在这个集合中的尾端加入
        Debug.Log("2场景数量是" + SceneManager.sceneCount);
        Scene newScene = SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
        //然后将这个场景激活
        SceneManager.SetActiveScene(newScene);
    }
}
