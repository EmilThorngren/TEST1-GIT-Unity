using UnityEngine;

public class Cube_Code : MonoBehaviour
{
    public float Movespeed = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.up * Movespeed) * Time.deltaTime;
    }
}
