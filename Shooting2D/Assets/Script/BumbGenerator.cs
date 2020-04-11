using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumbGenerator : MonoBehaviour
{
    // prefab을 플레이어의 위치에서 생성하는 스크립트

    // prefab
    public GameObject bumb;

    // player 위치
    public GameObject player;

    AudioSource audio;

    private void Start()
    {
        this.audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = this.player.transform.position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bObj = Instantiate(bumb) as GameObject;
            bObj.transform.position = new Vector2(playerPos.x - 1.5f, playerPos.y);

            // 생성되는 순간 던지는 오디오 재생
            audio.Play();
        }
    }
}
