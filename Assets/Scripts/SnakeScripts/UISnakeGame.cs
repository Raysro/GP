using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class UISnakeGame : MonoBehaviour
{
    public Text scoreTXT;
    public int score = 0;
    private void Update()
    {
        scoreTXT.text = "SCORE: " + score;
        
    }
    public void UpdateScore()
    {
        score += 10;
        if (score == 50)
        {
            SceneManager.LoadScene(2);
        }
    }
}
