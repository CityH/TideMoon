using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorManager : MonoBehaviour
{
public GameObject meteorPrefab;
public float spawnInterval;//掉落时间间隔
public float spwanHeight ;//高度y轴
public float spawnRadius;//x轴的范围

private void Start() {
//"SpawnMeteor"：表示要重复调用的方法名。
// spawnInterval：表示两次调用之间的时间间隔（以秒为单位）。
// spawnInterval：还表示第一次调用该方法前等待的时间。
     InvokeRepeating("SpawnMeteor", spawnInterval, spawnInterval);
}

void SpawnMeteor(){
    for (int i =0; i<=  Random.Range(0,3) ; i++)
    {
    Vector3 spwanPosition = new Vector3 (Random.Range(-spawnRadius, spawnRadius),spwanHeight,0);//设置范围
    Instantiate(meteorPrefab, spwanPosition, Quaternion.identity);//生产meteoPrefab这个实例
    }
}
}
