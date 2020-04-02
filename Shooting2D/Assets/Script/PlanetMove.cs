using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMove : MonoBehaviour
{
    Rigidbody2D target_rb;
    public float speed = 5.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        target_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // -> 방향으로 이동
        target_rb.velocity = new Vector2(1.0f, 0) * speed;

        // 화면 밖에 나가면 삭제
        if(transform.position.x > 11f)
        {
            Destroy(gameObject);
        }
    }

    
}
