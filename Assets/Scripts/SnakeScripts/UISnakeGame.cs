using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class UISnakeGame : MonoBehaviour
{
    public GameObject square;
    public Text scoreTXT;
    public int score = 0;
    private void Update()
    {
        scoreTXT.text = "SCORE: " + score;
        if (score == 50)
        {
            square.transform.Translate(-60f * Time.deltaTime, 0, 0);


        }
    }
    public void UpdateScore()
    {
        score += 10;
        if (score == 50)
        {
            StartCoroutine(delayScene());
            

        }
    }
    private IEnumerator delayScene() 
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
    }
}
