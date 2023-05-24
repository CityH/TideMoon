using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enmy : MonoBehaviour
{
    public static float minSpeed =1;
    public static float maxSpeed =2;
    private  float speed;
    // Player playerScript;
    public int damage;
    private static bool isSpeedIncreased = false;
    void Start()
    {
        if (ScoreManager.score >= ScoreManager.targetScore && !isSpeedIncreased)
        {
            Debug.Log("难度提升" + ScoreManager.score);
            isSpeedIncreased = true;
            // 增加Enmy的速度
                minSpeed += 1;
                maxSpeed += 1;

        }

        Debug.Log($"{minSpeed}-{maxSpeed}");
    }
    void Update()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        //掉落
        transform.Translate(Vector2.down * speed * Time.deltaTime);

    }


}
