using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text scoreText;//UI
    public static int targetScore = 20;
    public bool isSpeedIncreased =false;
    private void Start()
    {
        score = 0;
        // scoreText.text = "Score:" + score;
    }
    private void Update()
    {
        // Debug.Log("得分框被触发了"+score);
        scoreText.text = "Score:" + score;

    }
    public static void AddScore(int amount)
    {
        score += amount;
    }
    public void ResetScore()
    {
        score = 0;
    }
}
