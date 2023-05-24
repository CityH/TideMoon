using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Awake() {
        // DontDestroyOnLoad(transform.gameObject);
    }
    void Start()
    {
        TransitionManager.GetInstance().Transition("Persistent","MainMenu");
    }

    void Update()
    {
        
    }
}
