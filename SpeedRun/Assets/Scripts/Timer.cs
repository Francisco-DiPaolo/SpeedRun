using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text time;
    private float StartTime;
    public bool isplaying;
    private PlayerState player;
    //private Road road;
    public float TimeReset;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerState>();
        //road = GameObject.FindWithTag("Road").GetComponent<Road>();
        StartTime = Time.time;
        isplaying = true;
        TimeReset = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown("r") && !isplaying)
        {
            player.Respawn();
            //road.RespawnRoad();
            TimeReset = Time.time;
        }

        if (!isplaying) return;
        float t = Time.time - StartTime - TimeReset;

        string Minutos = ((int)t / 60).ToString();
        string Segundos = (t % 60).ToString("f2");

        if (t > 60)
        {
            time.text = Minutos + ":" + Segundos;
        }
        else time.text = Segundos;
    }

    public void Perder()
    {
        isplaying = false;
    }
}
