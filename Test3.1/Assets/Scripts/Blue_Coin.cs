using UnityEngine;

public class Blue_Coin : MonoBehaviour
{
    public Player_movement player_Movement;
    void Start()
    {
        player_Movement = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_movement>();
    }

    void Update()
    {
        if ((player_Movement.Coin_die) && (player_Movement.Player_Alive))
        {
            Destroy(gameObject);
        }
    }
}
