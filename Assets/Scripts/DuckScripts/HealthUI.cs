using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Scrollbar health;
    public GameObject Pause;
    public GameObject Won;
    public GameObject gameover;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseMenu();
        }
    }
    private void Start()
    {
        health.size = 1;
    }
    public void BaseDamage(float h)
    {
        Debug.Log(h);
        health.size = h*0.01f;
        if (h <= 0)
        {
            GameOver();
        }
    }
    public void PauseMenu()
    {
        Time.timeScale = 0;
        Pause.SetActive(true);
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

    public void GameOver()
    {
        gameover.SetActive(true);
        Time.timeScale = 0;
    }
}
