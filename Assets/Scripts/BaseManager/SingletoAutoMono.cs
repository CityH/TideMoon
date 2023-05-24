using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//创建单例模式的基类，用于让其他Manager去继承它
public class SingletoAutoMono <T>: MonoBehaviour where T:MonoBehaviour
{
//
private static T instance;
public static T GetInstance(){
    if(instance == null){
        GameObject obj = new GameObject();
        obj.name = typeof(T).ToString();
        instance = obj.AddComponent<T>();
    }
    return instance;
}
}
