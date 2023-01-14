using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class counter : MonoBehaviour
{
    float counter11;
    float counter12;
    public TextMeshProUGUI rabbit1;
    public TextMeshProUGUI duck1;
    public TextMeshProUGUI youwin;
  
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (counter12 == 30 && counter11 == 20)
        {
            Time.timeScale = 0;
            youwin.gameObject.SetActive(true);
        }
    }
    public void duck(float duck)
    {
        counter11 = duck + counter11;
        duck1.text = counter11.ToString();
        if (counter11 == 20&&counter12==30)
        {
           
            youwin.gameObject.SetActive(true);
            
        }
    }
    public void rabit(float rabit)
    {
        counter12 = rabit + counter12;
       
        rabbit1.text = counter12.ToString();
        if (counter12 == 30&&counter11==20)
        {
            youwin.gameObject.SetActive(true);
        }
    }
   
}
