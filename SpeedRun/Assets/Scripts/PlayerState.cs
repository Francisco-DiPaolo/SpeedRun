using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public bool isAlive;
    public Timer gameController;
    private Road road;
    private Player player;
    private GameObject Car;

    [SerializeField] Transform spawnPoint;

    void Start()
    {
        isAlive = true;
        gameController = GameObject.FindWithTag("GameController").GetComponent<Timer>();
        road = FindObjectOfType<Road>();
        player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            Debug.Log("Moriste");
            isAlive = false;
            Die();
        }
    }

    void Die()
    {
        gameController.Perder();
        road.velocidad = 0;
        player.vel = 0;
    }

    public void Respawn()
    {
        transform.position = spawnPoint.position;
        isAlive = true;
        gameController.isplaying = true;
        road.velocidad = 0.4f;
        player.vel = 40;
    }
}
