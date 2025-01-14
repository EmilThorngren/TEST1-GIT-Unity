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
    public float Delay_Time = 0.1f;
    public float Timer = 0;
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
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Grounded"))
        {
            nojump = false;     
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Grounded"))
        {
            while(Timer < Delay_Time)
            {
                Timer += Time.deltaTime;
            }
            nojump = true;
            Timer = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Logic.test++;
        Logic.Game_over();
        Player_Alive = false;
    }
}
  