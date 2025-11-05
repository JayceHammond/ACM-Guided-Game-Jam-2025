using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float speed;
    public int score;
    
    private Vector2 moveInput;
    private Rigidbody2D rb;
    public TextMeshProUGUI scoreText;
    public float gravity = 9.81f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveInput.y = gravity * Time.fixedDeltaTime;
        moveInput.x = Input.GetAxisRaw("Horizontal");
        
        scoreText.text = score.ToString();
        rb.linearVelocity = moveInput.normalized * speed;
    }
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Consumable"))
        {
            Destroy(collision.gameObject);
            score++;
        }
    }

}
