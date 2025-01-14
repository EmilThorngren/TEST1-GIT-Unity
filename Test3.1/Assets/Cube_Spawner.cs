using System.Threading;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Cube_Spawner : MonoBehaviour
{
    public GameObject Cube;
    public float Spawnrate = 2;
    private float Timer = 0;
    public float YaxisRange = 1;
    public float XaxisRange = 5;
    void Start()
    {
        Spawn();
    }


    void Update()
    {
        if (Timer < Spawnrate)
        {
            Timer = Timer + Time.deltaTime;
        }
        else
        {
            Spawn();
            Timer = 0;
        }
    }
    void Spawn()
    {
        float YLowestpoint = transform.position.y - YaxisRange;
        float YHighestpoint = transform.position.x + YaxisRange;
        float XLowestpoint = transform.position.x - XaxisRange;
        float XHighestpoint = transform.position.x + YaxisRange;
        Instantiate(Cube, new Vector3(Random.Range(XLowestpoint, XHighestpoint), Random.Range(YLowestpoint, YHighestpoint), 0), transform.rotation);
    }
}

