using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerSpawn2 : MonoBehaviour
{
    bool IsAlive = true;
    public GameObject _laserPrefab;
    public float spawnspeed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());

    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator SpawnRoutine()
    {
        float x = transform.position.x;
        while (IsAlive)
        {
            float randomNumber = Random.Range(16, 24);
            x = randomNumber;
            transform.position = new Vector3(x, 7.0f, 0);
            GameObject enemy = Instantiate(_laserPrefab, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(spawnspeed);
        }


    }
}
