using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    [SerializeField] GameObject platformPrefab;
    [SerializeField] int numberOfPlatforms;
    [SerializeField] float levelWidth = 3f;
    [SerializeField] float minY = 0.1f;
    [SerializeField] float maxY = 2f;
    private void Start()
    {
        Vector3 spawnPos = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPos, Quaternion.identity);
        }
        //StartCoroutine(spawner());
    }

}
