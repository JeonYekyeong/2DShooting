using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Rigidbody
    Rigidbody2D player_rb;
    // speed
    public float speed = 10.0f;

    // 좌우로 움직이기
    // 행성과 일정횟수만큼 충돌할 경우 GameOver
    // 포인트
    public static int POINT;

    // Start is called before the first frame update
    void Start()
    {
        player_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 좌우(앞뒤) 이동
        float vertical = Input.GetAxis("Vertical");

        // 화면 밖으로x
        Vector2 pos = transform.position;

        if (pos.y > 4.7f)
        {
            vertical = 0;
            pos.y = 4.7f;
        }
        else if(pos.y < -4.67f)
        {
            vertical = 0;
            pos.y = -4.67f;
        }
        // 위치
        transform.position = pos;

        player_rb.velocity = new Vector2(0, vertical) * speed;
    }

}
