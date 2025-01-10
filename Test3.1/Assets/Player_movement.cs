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
    public PLC PLC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PLC = GameObject.FindGameObjectsWithTag("PLC").GetComponent<PLC>();
    }
    
    [Obsolete]
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Speed * Move, rb.velocity.y);
        //Vector2 moveDirection = new Vector2(Speed * Move, rb.velocity.y);
        if (nojump == false && Input.GetButtonDown("Jump"))
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
            nojump = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

    }
}
  