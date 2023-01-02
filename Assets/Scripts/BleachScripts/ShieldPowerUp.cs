using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUp : MonoBehaviour
{
    public GameObject player;
    public float counter=0;
   public AudioSource audioSource;
    public AudioClip audioClip;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
          
               
             
          
            Move2 m = GameObject.Find("Ichigo").GetComponent<Move2>();
            m.score1(1);
            m.shieldactive();
            audioSource.clip = audioClip;
            audioSource.Play();
            Destroy(this.gameObject);
           
           
            
          
          
        }
    }
    
    
    
}
