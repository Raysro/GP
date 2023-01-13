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

    private void Start()
    {
        playerScoreTXT.text = ""+playerScore;
        AIScoreTXT.text = ""+AIScore;

    }

    public void PlayerScored()
    {
        playerScore++;
        playerScoreTXT.text =""+playerScore;
    }
    public void AIScored()
    {
        AIScore++;
        AIScoreTXT.text = ""+AIScore;
    }
    private void Update()
    {
        if (playerScore >= 3)
        {
            SceneManager.LoadScene(4);
        }
    }
}
