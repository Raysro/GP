using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField]
        private Image _LiveSprites;
    [SerializeField]
    private Sprite[] Sprites;
    private GameManager gameManager;
    //
    //Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    public void UpdateLives(int lives)
    {
        _LiveSprites.sprite = Sprites[lives]; 
    }

  public void resumegame()
    {
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.resumegame();
    }
   /* public void mainmenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }*/
}
