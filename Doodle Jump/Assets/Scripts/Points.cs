using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour
{
    //[SerializeField] Text txt; [SerializeField] int points;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("Score").transform.GetComponent<Score>().ScorePoints += 1;
            Destroy(gameObject);
        }
    }
}
