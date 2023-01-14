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
    public GameObject WonSnake;
    public GameObject Pause;
    public float ss= -60f;
    public Text scoreTXT;
    public int score = 0;
    public GameObject[] LivesSP;
    private void Update()
    {
        scoreTXT.text = "" + score;
        if (score == 50&& square!= null)
        {
            square.transform.Translate(ss * Time.deltaTime, 0, 0);
            if (square.transform.position.x <= -22f)
            {
                ss = 0;
            }

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseMenu();
        }
    }
    public void livesSp(int lives)
    {
        if(lives==0)
            LivesSP[lives].SetActive(false);
        if (lives == 1)
            LivesSP[lives].SetActive(false);
        if (lives == 2)
            LivesSP[lives].SetActive(false);
    }
    public void UpdateScore()
    {
        score += 10;
        if (score == 50)
        {
            StartCoroutine(delayScene());
            

        }
    }
    public void PauseMenu()
    {
        Time.timeScale = 0;
        Pause.SetActive(true);
    }
    private IEnumerator delayScene() 
    {
        WonSnake.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        Pause.SetActive(false);
    }
    


}
