using System.Threading;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Cube_Spawner : MonoBehaviour
{
    public GameObject Cube_1_2;
    public GameObject Cube_3_4;
    public float Spawnrate = 2;
    public float Timer = 0;
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
        float YHighestpoint = transform.position.y + YaxisRange;
        float XLowestpoint = transform.position.x - XaxisRange;
        float XHighestpoint = transform.position.x + YaxisRange;
        Instantiate(Cube_1_2, new Vector3(Random.Range(XLowestpoint, XHighestpoint), Random.Range(YLowestpoint, YHighestpoint), 0), transform.rotation);
        Instantiate(Cube_3_4, new Vector3(Random.Range(XLowestpoint, XHighestpoint), Random.Range(YLowestpoint, YHighestpoint), 0), transform.rotation);
    }
}

