using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//创建一个单例类型作为父类
public class SingletoAtuoMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T GetIntstance()
    {
        if (instance == null)
        {
            GameObject obj = new GameObject();
            obj.name = typeof(T).ToString();
            instance = obj.AddComponent<T>();
        }
        return instance;
    }
}
