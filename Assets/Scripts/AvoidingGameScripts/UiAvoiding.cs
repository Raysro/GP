using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UiAvoiding : MonoBehaviour
{
    public GameObject Pause;
    public GameObject Won;
    public Text scoreAO;
    int scorenum = 0;
    void Start()
    {

        StartCoroutine(scoreHandel());
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseMenu();
        }
        scoreAO.text = ""+scorenum;
        if (scorenum == 200)
        {
            StartCoroutine(delayScene());
            
        }
    }
    private IEnumerator scoreHandel()
    {
        
        
            yield return new WaitForSeconds(3f);
        
        while (true)
        {
            scorenum++;
            yield return new WaitForSeconds(0.2f);
        }

    }
    private IEnumerator delayScene()
    {
        Won.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(6);
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

}
