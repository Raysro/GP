using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class UISnakeGame : MonoBehaviour
{
    public GameObject[] boards;
    public GameObject[] Warning;
    public Text scoreTXT;
    public int score = 0;
    private void Update()
    {
        scoreTXT.text = "SCORE: " + score;
        if (score == 40)
        {
            Warning[0].SetActive(true);
            Warning[1].SetActive(true);
        }
        if (score == 50)
        {
            boards[0].SetActive(true);
            boards[1].SetActive(true);
        }
        if (score == 120)
        {
            Warning[2].SetActive(true);
            Warning[3].SetActive(true);
        }
        if (score == 130)
        {
            boards[2].SetActive(true);
            boards[3].SetActive(true);
        }
        if (score == 200)
        {
            Warning[4].SetActive(true);
            Warning[5].SetActive(true);
        }
        if (score == 210)
        {
            boards[4].SetActive(true);
            boards[5].SetActive(true);
        }
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
