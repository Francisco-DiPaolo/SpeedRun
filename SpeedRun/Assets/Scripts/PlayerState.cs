using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public bool isAlive;
    public Timer gameController;

    [SerializeField] Transform spawnPoint;

    void Start()
    {
        isAlive = true;
        gameController = GameObject.FindWithTag("GameController").GetComponent<Timer>();
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
    }

    public void Respawn()
    {
        transform.position = spawnPoint.position;
        isAlive = true;
        gameController.isplaying = true;
    }
}
