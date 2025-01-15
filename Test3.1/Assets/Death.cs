using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float Movespeed = 2.0f;
    public float Set_Start_Time = 25;
    public float Timer = 0.0f;
    public float acceleration = 1.01f;
    

    void Start()
    {
        while (Timer < Set_Start_Time)
        {
            Timer += Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Raising_vector();
        Timer = 0;
    }

    void Raising_vector()
    {
        transform.position += (Vector3.up * Movespeed * acceleration) * Time.deltaTime;

    }



    

}
