using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    public float radius = 75;
    public GameObject hazard;
    public int hazardCount = 50;
    public float spawnWait = 0.5f;
    public float startWait = 2f;
    public float waveWait = 5f;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                InstantiateHazard(CreateRandomRadiusPos());
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

    void InstantiateHazard(Vector2 position)
    {
        Instantiate(hazard, position, Quaternion.identity);
    }

    Vector2 CreateRandomRadiusPos(){
        float angle = Random.Range(0, 360);
        return new Vector2(radius * Mathf.Cos(angle), radius * Mathf.Sin(angle));
    }
}
