using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.EventSystems;
public class Player : MonoBehaviour
{
    [SerializeField] GameObject panel;
    //[SerializeField] int points;
    //bool isAlive = true;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Death")
        {
            Destroy(gameObject);
            panel.gameObject.SetActive(true);

        }

    }

}
