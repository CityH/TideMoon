using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb;
    private int life =3 ;
    Animator anim;
    public float minX, maxX;
    public GameObject life1, life2, life3;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("人物已触发");
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            int heart = --life;
            Life(heart);
            Debug.Log($"ֵ玩家生命值是{life}");
        }
    }

    private void Life(int heart)
    {
        switch (heart)
        {
            case 3:
                life3.SetActive(true);
                life2.SetActive(true);
                life1.SetActive(true);
                break;
            case 2:
                life3.SetActive(false);
                life2.SetActive(true);
                life1.SetActive(true);
                break;
            case 1:
                life3.SetActive(false);
                life2.SetActive(false);
                life1.SetActive(true);
                break;
            case 0:
                life3.SetActive(false);
                life2.SetActive(false);
                life1.SetActive(false);
                GameOver();
                break;
        }
    }
    public void GameOver()
    {
        // Time.timeScale = 0;
        TransitionManager.GetInstance().Transition("Game", "MainMenu");
    }

    private void LateUpdate()
    {
        Vector3 pos = transform.position; // 获取人物的当前位置

        // 根据边界的最小和最大值来限制人物的移动范围
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        transform.position = pos; // 更新人物的位置
    }
}
