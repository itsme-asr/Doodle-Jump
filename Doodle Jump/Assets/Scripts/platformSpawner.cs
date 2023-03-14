using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    [SerializeField] GameObject platformPrefab;
    [SerializeField] Transform wavePoints1;
    [SerializeField] Transform wavePoints2;
    [SerializeField] float minDelay = 0.1f;
    [SerializeField] float maxDelay = 2f;
    private void Start()
    {
        StartCoroutine(spawner());
    }

    IEnumerator spawner()
    {
        while (true)
        {
            float Delay = Random.Range(minDelay, maxDelay);
            float randomX = Random.Range(wavePoints1.position.x, wavePoints2.position.x);
            Vector3 position = new Vector3(randomX, wavePoints1.position.y, wavePoints1.position.z);
            yield return new WaitForSeconds(Delay);
            GameObject clonePlatform = Instantiate(platformPrefab, position, Quaternion.identity);
        }
    }
}
