using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
    // Debug.Log("得分线已触发");
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            ScoreManager.AddScore(5);
        }
        
    }
}

