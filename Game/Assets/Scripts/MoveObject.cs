﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed ;
    void Update()
    {
        transform.Translate(Vector2.left * speed);
        if (transform.position.x < -9)// 장애물을 넘어서 화면 밖으로 가면 삭제
        {
            Destroy(gameObject);
        }
    }

}
