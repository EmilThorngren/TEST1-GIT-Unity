using UnityEngine;

public class Special_Cube_Spawner : MonoBehaviour
{
    public GameObject Special_Jump_Cube;
    public GameObject Blue_Coin_Cube;
    public float Spawnrate;
    public float Timer = 0;
    public float YaxisRange = 20;
    public float XaxisRange = 10;
    public GameObject Target; 
    public Player_movement player_Movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player_Movement = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_movement>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < Spawnrate)
        {
            Timer += Time.deltaTime;
        }
        else
        {
            Spawn_Special();
            Timer = 0;
        }
        if (transform.position.y < Target.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
    public void Spawn_Special()
    {
        float YLowestpoint = transform.position.y - YaxisRange;
        float YHighestpoint = transform.position.y + YaxisRange;
        float XLowestpoint = transform.position.x - XaxisRange;
        float XHighestpoint = transform.position.x + YaxisRange;
        Instantiate(Special_Jump_Cube, new Vector3(Random.Range(XLowestpoint, XHighestpoint), Random.Range(YLowestpoint, YHighestpoint), 0), transform.rotation);
        Instantiate(Blue_Coin_Cube, new Vector3(Random.Range(XLowestpoint, XHighestpoint), Random.Range(YLowestpoint, YHighestpoint), 0), transform.rotation);
    }
}
