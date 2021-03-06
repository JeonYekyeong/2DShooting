﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // 폭탄이 움직임, 충돌감지 스크립트 

    Rigidbody2D b_rb;

    // 폭탄 움직이는 속도
    public float speed = 1.5f;

    AudioSource audio;  // 플레이어기

    // Start is called before the first frame update
    void Start()
    {
        this.b_rb = GetComponent<Rigidbody2D>();
        this.audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        b_rb.velocity = new Vector2(1.0f,0) * -speed;

        // 화면 밖에 나가면 삭제  -4.47 ~ 4.42
        if (transform.position.x < -10.94 || transform.position.y <= -5.28 || transform.position.y >= 5.3)
        {
            Destroy(gameObject);
        }
    }

    // 행성과 충돌하면 삭제
    private void OnTriggerEnter2D(Collider2D collision)
    {
        audio.Play();
        // 딜레이 
        Destroy(gameObject, 0.1f);

        // 행성 파괴시 100점 추가
        PlayerController.POINT += 100;
    }
}
