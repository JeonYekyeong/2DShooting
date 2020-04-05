using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumbGenerator : MonoBehaviour
{
    // prefab
    public GameObject bumb;

    // player 위치
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = this.player.transform.position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bObj = Instantiate(bumb) as GameObject;
            bObj.transform.position = new Vector2(playerPos.x - 1.5f, playerPos.y);
        }
    }
}
