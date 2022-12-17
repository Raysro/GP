using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIAsteroids : MonoBehaviour
{
    public Text score;
    int Sp=0;
    private void Start()
    {
        score.text = "Score: " + Sp;
    }
    public void UpdateScore(int points)
    {
        Sp += points;
        score.text = "Score: " + Sp;
    }
}
