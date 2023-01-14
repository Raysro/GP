using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text playerScoreTXT;
    public Text AIScoreTXT;
    [SerializeField] int playerScore = 0;
    int AIScore = 0;
    public GameObject Pause;
    public GameObject WonSnake;
    public GameObject gameover;
    private void Start()
    {
        playerScoreTXT.text = ""+playerScore;
        AIScoreTXT.text = ""+AIScore;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseMenu();
        }
    }

    public void PlayerScored()
    {
        playerScore++;
        playerScoreTXT.text =""+playerScore;
        if (playerScore == 3)
        {
            StartCoroutine(delayScene());
        }
    }
    public void AIScored()
    {
        AIScore++;
        AIScoreTXT.text = ""+AIScore;
        if (AIScore == 3)
            GameOver();
    }

    private IEnumerator delayScene()
    {
        WonSnake.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(4);
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
