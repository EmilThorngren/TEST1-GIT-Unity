using UnityEngine;
using UnityEngine.SceneManagement;

public class PLC : MonoBehaviour
{
    public Player_movement player_Movement;
    public bool pause = false;
    void Start()
    {
        player_Movement = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_movement>();
    }

    public GameObject Game_overScreen;
    public int test = 0;
    public void Game_over()
    {
        test++;
        Game_overScreen.SetActive(true);
        Time.timeScale = 0;

    }
    public void Game_restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Game_Screen()
    {
        SceneManager.LoadScene(1);
    }
    public void Start_Screen()
    {
        SceneManager.LoadScene(0);
    }
    public void Paused()
    {
        if (pause == false && player_Movement.Player_Alive)
        {
            pause = true;
            Debug.Log("Paused");
            Time.timeScale = 0;
        }
        else
        {
            pause = false;
            Time.timeScale = 1;
        }
    }
}
