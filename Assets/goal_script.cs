using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class goalScript : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    public ball_script ball;
    public player_script player1;
    public player2_script player2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ball = collision.gameObject.GetComponent<ball_script>();

        if (ball != null )
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke( eventData );  
        }
    }
}
