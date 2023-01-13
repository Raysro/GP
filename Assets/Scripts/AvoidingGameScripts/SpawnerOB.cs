using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOB : MonoBehaviour
{
    public GameObject[] Obs;
    void Start()
    {
        StartCoroutine(spawnOB1());
    }
    private IEnumerator spawnOB1()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(Obs[Random.Range(0, 3)],transform.position=new Vector3(Random.Range(-7f,7f),15f,0f),transform.rotation);
        }
    }
}
