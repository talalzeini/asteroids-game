using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Obstacle : MonoBehaviour
{
    public float speed;
    private GameManager gameManager;
    private void Update()
    {
        if (gameObject.CompareTag("Planet"))
        {
            if(transform.position.x < -30f)
            {
                Destroy(gameObject);
            }
        }
        else if(gameObject.CompareTag("Asteroid"))
        {
            if(transform.position.x < -15f)
            {
                Destroy(gameObject);
            }
        }

        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if(speed <= 20)
        {
            speed += Time.deltaTime * 0.025f;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().TryAgain();
            FindObjectOfType<Player>().Explode();
        }
    }

}
    





