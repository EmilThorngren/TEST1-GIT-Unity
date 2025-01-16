using UnityEngine;
using UnityEngine.SceneManagement;

public class PLC : MonoBehaviour
{
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

}
