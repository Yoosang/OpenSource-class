﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Character : MonoBehaviour
{
    public Slider HpSlider;

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Animator>().Play("jump");
            StartCoroutine(JumpBtn());
        }
        if (HpSlider.value == 0)
        {
            GameController.Instance().GameOver();
            Time.timeScale = 0; // 죽었을 때 캐릭터 모습이 없어서 정지 기킨 것
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "test")
        {
            HpSlider.value -= 0.5f;
            Destroy(col.gameObject);
        }
    }

    IEnumerator JumpBtn()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 330f);
        yield return new WaitForSeconds(1.0f);
    }

}
