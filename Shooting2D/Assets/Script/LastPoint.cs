using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastPoint : MonoBehaviour
{
    // UI갱신
    public Text lastPoint;

    // Update is called once per frame
    void Update()
    {
        lastPoint.text = "Point : " + PlayerController.POINT;
    }
}
