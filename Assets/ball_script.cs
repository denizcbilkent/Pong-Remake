using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_script : MonoBehaviour
{

    public Rigidbody2D ball;
    public int speed;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

    }

    public void ResetPos() {
        ball.position = Vector2.zero;
        ball.velocity = Vector2.zero;
    }

    public void Reset()
    {   
        ResetPos();
        timer = 0;
        Launch();
        
    }

    public void Launch()
    {
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        ball.velocity = new Vector2(speed * x, speed * y);
    }
}
