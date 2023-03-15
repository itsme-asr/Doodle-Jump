using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamondSpawner : MonoBehaviour
{
    [SerializeField] GameObject diamondPrefab;
    [SerializeField] int numberOfPlatforms;
    [SerializeField] float levelWidth = 8f;
    [SerializeField] float minY = 1f;
    [SerializeField] float maxY = 2f;
    private void Start()
    {
        Vector3 spawnPos = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(diamondPrefab, spawnPos, Quaternion.identity);
        }
        //StartCoroutine(spawner());
    }
}
