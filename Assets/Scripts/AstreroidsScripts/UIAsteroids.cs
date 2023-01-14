using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIAsteroids : MonoBehaviour
{
    public GameObject square;
    public GameObject Pause;
    public GameObject Won;
    public Text score;
    public int Sp =0;
    public float ss = -40f;
    public GameObject[] livesSprite;
    private void Start()
    {
        score.text = "" + Sp;
       
    }
    private void Update()
    {
        
            
        square.transform.Translate(ss* Time.deltaTime, 0, 0);
        if(square.transform.position.x<= -22f ) {
            ss = 0;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseMenu();
        }
    }
    public void UpdateScore(int points)
    {
        
        Sp += points;
        score.text = "" + Sp;
        if (Sp == 50)
        {

            StartCoroutine(delayScene());
        }
    }
    public void UpdateLives(int l)
    {
        if(l==2)
            livesSprite[l].SetActive(false);
        if (l == 1)
            livesSprite[l].SetActive(false);
        if (l == 0)
            livesSprite[l].SetActive(false);

    }
    private IEnumerator delayScene()
    {
        Won.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(3);
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
