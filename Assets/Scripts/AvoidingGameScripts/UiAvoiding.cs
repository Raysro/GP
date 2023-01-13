using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiAvoiding : MonoBehaviour
{
    public Text scoreAO;
    int scorenum = 0;
    void Start()
    {
        StartCoroutine(scoreHandel());
    }

    
    void Update()
    {
        scoreAO.text = ""+scorenum;
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
}
