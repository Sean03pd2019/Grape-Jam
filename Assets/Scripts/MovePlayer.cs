using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Rigidbody2D player;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.AddForce(Vector2.right * 300);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.AddForce(Vector2.left * 300);

        }
        if (Input.GetKey(KeyCode.Space) && time < 0)
        {
            player.velocity += Vector2.up * 5;
            time = 1.1f;
        }
        time -= Time.deltaTime;
    }
}