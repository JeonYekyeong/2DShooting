using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGenerator : MonoBehaviour
{
    // TargetPrefab
    public GameObject targetPrefab;
    // 행성 생성 시간 간격
    public float span = 0.8f;
    // 시간
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        // Time.deltaIme으로 더한 값이 0.8이상이면 초기화 및 Prefab생성
        if(delta > 0.8)
        {
            this.delta = 0;

            // 생성
            GameObject obj = Instantiate(targetPrefab) as GameObject;

            // y : -4.47 ~ 4.42 에 범위에서 랜덤 생성
            float pos = Random.Range(-4.47f, 4.43f);
            obj.transform.position = new Vector3(-11f, pos, 0);
        }
    }

}
