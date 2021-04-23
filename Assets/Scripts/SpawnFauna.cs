using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class used to sqawn the trees and rocks.
public class SpawnFauna : MonoBehaviour
{
    public GameObject[] faunaPrefabs;
    int spawnCount;

    void Start()
    {
        spawnCount = Random.Range(150, 300);
        for (int i = 0; i < spawnCount; i++)
        {
            Vector3 dir = Random.onUnitSphere;
            // Only spawn fauna on the side of the planet that faces the camera.
            if (dir.z > 0) dir = (dir * -1); // Flip z position if it is positive.
            SpawnObj(dir);
        }
    }

    void SpawnObj(Vector3 dir)
    {
        int faunaID = Random.Range(0, faunaPrefabs.Length); // Randomly select a fauna to instantiate.
        Vector3 spawnPoint = transform.position;
        
        spawnPoint += dir * transform.localScale.y / 2;
        Vector3 spawnRotation = (spawnPoint - transform.position).normalized;
        GameObject addFauna = Instantiate(faunaPrefabs[faunaID], spawnPoint, new Quaternion(0, 0, 0, 0));
        addFauna.transform.rotation = Quaternion.FromToRotation(addFauna.transform.up, spawnRotation) * addFauna.transform.rotation;
    }
}
