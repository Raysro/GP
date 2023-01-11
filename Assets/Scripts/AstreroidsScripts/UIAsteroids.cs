using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIAsteroids : MonoBehaviour
{
    public GameObject square;
    public Text score;
    public int Sp =0;
    public float ss = -40f;
    public GameObject[] livesSprite;
    private void Start()
    {
        score.text = "Score: " + Sp;
    }
    private void Update()
    {
        
            
        square.transform.Translate(ss* Time.deltaTime, 0, 0);
        if(square.transform.position.x<= -22f ) {
            ss = 0;
        }
    }
    public void UpdateScore(int points)
    {
        
        Sp += points;
        score.text = "Score: " + Sp;
        if (Sp == 50)
        {
            SceneManager.LoadScene(3);
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
}
