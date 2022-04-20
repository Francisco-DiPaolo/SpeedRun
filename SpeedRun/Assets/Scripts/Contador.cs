using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public int count;
    public Text textSpeed;
    void Start()
    {
        count = 0;
        SetCountText();
    }
    public void Punto()
    {
        count++;
        SetCountText();
    }

    public void SetCountText()
    {
        textSpeed.text = "Speed:" + " " + "+" + count.ToString();
    }
}
