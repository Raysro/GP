using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIAsteroids : MonoBehaviour
{
    public Text score;
    public int Sp =0;
    public GameObject[] livesSprite;
    private void Start()
    {
        score.text = "Score: " + Sp;
    }
    public void UpdateScore(int points)
    {
        Sp += points;
        score.text = "Score: " + Sp;
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
