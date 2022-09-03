using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public GameObject explosionEffect;
    public float down;
    public float up;
    public float time = 5000f;
    private float timeStore;


    private void Start()
    {     
        timeStore = time;
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float y = Input.GetAxisRaw("Vertical") * Time.fixedDeltaTime * moveSpeed;
        Vector2 newPosition = rb.position + Vector2.up * y;
        newPosition.y = Mathf.Clamp(newPosition.y, down, up);
        rb.MovePosition(newPosition);  
    }
    public void Explode()
    {
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

