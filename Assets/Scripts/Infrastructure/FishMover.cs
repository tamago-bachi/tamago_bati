﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FishMover : MonoBehaviour
{
    int count = 0;
    float speed;

    const int MAX_COUNT = 60;

    void Start()
    {
        speed = Random.Range(0.5f, 2f);
        transform.localScale = transform.localScale * Random.Range(0.4f, 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        count--;
        transform.position += transform.forward / 100 * speed;
    }

    void SetRandomDirection()
    {
        float x = Random.Range(-90, 90),
            y = Random.Range(0, 360),
            z = 0; //Random.Range(0, 360);
        transform.rotation =
            Quaternion.Euler(new Vector3(x, y, z));
    }

    void FixedUpdate()
    {
        if (CheckWall())
        {
            SetRandomDirection();
            count = MAX_COUNT;
        }
        else
        {
            if (Input.GetMouseButton(0) && count < 0)
            {
                var mousePos = Input.mousePosition;
                mousePos.z = 6;
                var worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);
                transform.LookAt(worldMousePos);
            }
        }
    }

    bool CheckWall()
    {
        //int wallMask = LayerMask.NameToLayer("Wall");
        var rayResult = Physics.Raycast(transform.position, transform.forward, 1.0f);
        Debug.DrawRay(transform.position, transform.forward * 1.0f, Color.red, 5);
        return rayResult;
    }
}