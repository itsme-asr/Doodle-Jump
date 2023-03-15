using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isPressed = false;
    [SerializeField] GameObject player;
    [SerializeField] float force;

    private void Update()
    {
        if (isPressed)
        {
            //player.transform.Translate(force * Time.deltaTime, 0, 0);
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(force * Time.deltaTime, 0), ForceMode2D.Impulse);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
