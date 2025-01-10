using UnityEngine;

public class PLC : MonoBehaviour
{
    public GameObject Game_overScreen;


    public void Game_over()
    {
        Game_overScreen.SetActive(true);
    }
}
