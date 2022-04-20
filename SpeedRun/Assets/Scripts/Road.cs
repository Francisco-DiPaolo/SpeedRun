using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [Range(0, 1)]
    public float velocidad;

    [SerializeField] Transform spawnPoint;

    void FixedUpdate()
    {
        transform.Translate(0, 0, -velocidad);
    }

    public void RespawnRoad()
    {
        transform.position = spawnPoint.position;
    }
}
