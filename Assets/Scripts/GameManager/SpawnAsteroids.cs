using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    public float radius = 30;
    public GameObject hazard;
    public int hazardCount = 20;
    public float spawnWait = 0.5f;
    public float startWait = 2f;
    public float waveWait = 5f;
    public Vector2[] spawnValues;
    float rangeExtent = 100f;

    void Start()
    {
        spawnValues = new[] {
            new Vector2(Random.Range(-rangeExtent, rangeExtent), 100),
            new Vector2(100, Random.Range(-rangeExtent, rangeExtent)),
            new Vector2(Random.Range(-rangeExtent, rangeExtent), -100),
            new Vector2(-100, Random.Range(-rangeExtent, rangeExtent)),
            };
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            int p = 0;
            for (int i = 0; i < hazardCount; i++)
            {
                InstantiateHazard(spawnValues[p]);
                if (p < spawnValues.Length - 1) { p++; } else { p = 0; }
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

    void InstantiateHazard(Vector2 position)
    {
        Instantiate(hazard, position, Quaternion.identity);
    }
}
