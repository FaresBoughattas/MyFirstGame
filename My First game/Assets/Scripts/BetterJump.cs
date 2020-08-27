﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    Rigidbody2D rb;
     void Awake()
    {
        rb = GetComponent<Rigidbody2D> ();

     }
    void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += new Vector2(rb.velocity.x, Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime);
        }
        else if (rb.velocity.y > 0 && !(Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)))
        {
            rb.velocity += new Vector2(rb.velocity.x, Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime);
        }
    }
}
