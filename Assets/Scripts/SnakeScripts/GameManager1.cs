using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{

     public void startGame()
    {
        SceneManager.LoadScene(1);
    }

   
    void Update()
    {
        if (FindObjectOfType<UISnakeGame>().score == 50)
            SceneManager.LoadScene(2);

        if (FindObjectOfType<UIAsteroids>().Sp == 50)
        {
            Debug.Log("50");
            SceneManager.LoadScene(3);
        }
    }
}
