using System;
using UnityEngine;
public class Player_movement : MonoBehaviour
{
    public float Speed= 5;
    private float Move;
    public float Jump_Power;
    private Rigidbody2D rb;
    public bool nojump = true;
    public bool Player_Alive = true;
    public PLC Logic;
    public float Extra_Jump = 2;
    public bool Coin_die = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Logic = GameObject.FindGameObjectWithTag("PLC").GetComponent<PLC>();
    }
    [Obsolete]
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        if (Player_Alive)
        {
            rb.velocity = new Vector2(Speed * Move, rb.velocity.y);
        }
        //Vector2 moveDirection = new Vector2(Speed * Move, rb.velocity.y);
        if (Player_Alive && nojump == false && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, Jump_Power)); 
        } 
   }
    [Obsolete]
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Grounded"))
        {
            nojump = false;     
        }
        if (other.gameObject.CompareTag("BigJump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, (Extra_Jump * Jump_Power)));
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Grounded"))
        {
            nojump = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Void"))
        {
            Logic.test++;
            Logic.Game_over();
            Debug.Log("Player dead");
            Player_Alive = false;
        }
        if ( collision.gameObject.CompareTag("Blue_Coin"))
        {
            Jump_Power += 100;
            Coin_die =true;
        }
    }
}
  