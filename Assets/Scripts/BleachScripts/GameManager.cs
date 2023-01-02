using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject puasepanel;
    private bool _isplayerdead=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void GameOver()
    {
        _isplayerdead=true;
    }
    // Update is called once per frame
    void Update()
    {
        if (_isplayerdead && Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
       
        if (Input.GetKeyUp(KeyCode.P))
        {
            pausefunction();
        }
    }
    private void pausefunction()
    {
        Time.timeScale=0;
        puasepanel.gameObject.SetActive(true);
    }
    public void resumegame()
    {
        Time.timeScale = 1;

        puasepanel.SetActive(false);
    }
}
