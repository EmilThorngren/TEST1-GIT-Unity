using System;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float Speed= 5;
    public float Move =5;
    public float Jump_Power;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    [Obsolete]
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Speed * Move, rb.velocity.y);
        Vector2 moveDirection = new Vector2(Speed * Move, rb.velocity.y);



    }
}

internal struct NewStruct
{
    public float Item1;
    public float y;

    public NewStruct(float item1, float y)
    {
        Item1 = item1;
        this.y = y;
    }

    public override bool Equals(object obj)
    {
        return obj is NewStruct other &&
               Item1 == other.Item1 &&
               y == other.y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Item1, y);
    }

    public void Deconstruct(out float item1, out float y)
    {
        item1 = Item1;
        y = this.y;
    }

    public static implicit operator (float, float y)(NewStruct value)
    {
        return (value.Item1, value.y);
    }

    public static implicit operator NewStruct((float, float y) value)
    {
        return new NewStruct(value.Item1, value.y);
    }
}