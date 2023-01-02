using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

     public void startGame()
    {
        SceneManager.LoadScene(1);
    }

   
    void Update()
    {
        if (FindObjectOfType<UISnakeGame>().score == 100)
            SceneManager.LoadScene(2);

        if (FindObjectOfType<UIAsteroids>().Sp == 100)
            SceneManager.LoadScene(3);
    }
}
