using UnityEngine;
using UnityEngine.UI;
public class Score_Counter : MonoBehaviour
{
    public Text Score_text;
    public float Player_Height;
    public GameObject Target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Target.transform.position.y > Player_Height)
        {
            Player_Height = Target.transform.position.y;
        }
        Score_text.text = Player_Height.ToString();
    }

}
