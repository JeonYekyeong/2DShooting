using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    Rigidbody2D b_rb;

    // 폭탄 움직이는 속도
    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        this.b_rb = GetComponent<Rigidbody2D>();
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
        Destroy(gameObject);
    }
}
