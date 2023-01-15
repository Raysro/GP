using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    //[SerializeField]
    //    private Image _LiveSprites;
    //[SerializeField]
    //private Sprite[] Sprites;
    private GameManager gameManager;
    public GameObject Pause;
    public GameObject Won;
    public GameObject[] LivesSP;
    //
    //Start is called before the first frame update
    void Start()
    {
      
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseMenu();
        }
    }
    // Update is called once per frame
    public void UpdateLives(int lives)
    {
        //_LiveSprites.sprite = Sprites[lives]; 
    }

  public void resumegame()
    {
        //gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
        //gameManager.resumegame();
    }
    /* public void mainmenu()
     {
         SceneManager.LoadScene(0);
         Time.timeScale = 1;
     }*/

    
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
    public void lives(int l)
    {
        if(l==2)
        LivesSP[0].SetActive(false);
        if (l == 1)
            LivesSP[1].SetActive(false);
        if (l == 0)
            LivesSP[2].SetActive(false);
    }
}
