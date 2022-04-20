using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour
{
    public bool isAlive;
    public Timer gameController;
    //private Road road;
    private Player player;
    private Contador contador;
    private GameObject Car;
    public GameObject powerUp;

    [SerializeField] Transform spawnPoint;

    void Start()
    {
        isAlive = true;
        gameController = GameObject.FindWithTag("GameController").GetComponent<Timer>();
        //road = FindObjectOfType<Road>();
        player = FindObjectOfType<Player>();
        contador = FindObjectOfType<Contador>();
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            player.vel += 1;
            Destroy(other.gameObject);
            contador.Punto();
        }  
    }

    void Die()
    {
        gameController.Perder();
        //road.velocidad = 0;
        player.vel = 0;
    }

    public void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        /*transform.position = spawnPoint.position;
        isAlive = true;
        gameController.isplaying = true;
        road.velocidad = 0.4f;
        player.vel = 40;*/
    }
}
