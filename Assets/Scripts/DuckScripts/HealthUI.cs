using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Scrollbar healthBar;
    float health = 100;
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
        healthBar.size = 1;
    }
    public void BaseDamage()
    {
        health -= 10f;
        Debug.Log(health);
        healthBar.size = health*0.01f;
        if (health <= 0)
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
