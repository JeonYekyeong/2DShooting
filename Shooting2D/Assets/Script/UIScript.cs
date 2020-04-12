using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    // UI갱신
    public Text myPoint;
    public Text myLife;

    // Update is called once per frame
    void Update()
    {
        myPoint.text = "Point : " + PlayerController.POINT;
        myLife.text = "Life : " + PlayerController.COUNT;
    }
}
