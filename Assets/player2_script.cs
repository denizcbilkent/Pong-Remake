using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_script : MonoBehaviour
{
    public Rigidbody2D player;
    public float moveSpeed2 = 15;
    public static bool isPlayer = true;
    public ball_script ball;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer) { 
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(9f, -5f, 0f), moveSpeed2 * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(9f, 5f, 0f), moveSpeed2 * Time.deltaTime);
            }
        } else
        {
            if (this.ball.ball.position.y > this.transform.position.y)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(9f, 5f, 0f), moveSpeed2 * Time.deltaTime);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(9f, -5f, 0f), moveSpeed2 * Time.deltaTime);
            }
        }


    }
    public void Reset()
    {
        player.position = new Vector2(player.position.x, 0);
    }
}
