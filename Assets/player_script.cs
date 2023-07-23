using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    public Rigidbody2D player;
    public float moveSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player2_script.isPlayer)
        {
            if (Input.GetKey(KeyCode.S))
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(-9f, -5f, 0f), moveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(-9f, 5f, 0f), moveSpeed * Time.deltaTime);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(-9f, -5f, 0f), moveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(-9f, 5f, 0f), moveSpeed * Time.deltaTime);
            }
        }

    }

    public void Reset()
    {
        player.position = new Vector2(player.position.x, 0);
    }
}
