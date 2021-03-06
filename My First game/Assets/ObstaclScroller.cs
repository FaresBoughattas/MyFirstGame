﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclScroller : MonoBehaviour
{
    public Transform begin, end;
    public float scrollSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
        if (transform.position.x <= end.position.x)
        {
            transform.position = new Vector3(begin.position.x, Random.Range(-0.22f,3.54f), 0);
        }
    }
}
