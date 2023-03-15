using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour
{
    [SerializeField] GameObject pointsEffect;
    //[SerializeField] int points;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("Score").transform.GetComponent<Score>().ScorePoints += 1;
            Destroy(gameObject);
            GameObject effect = Instantiate(pointsEffect, transform.position, Quaternion.identity);
            Destroy(effect, .5f);
        }
    }
}
