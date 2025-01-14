using UnityEngine;

public class CamScirpt : MonoBehaviour
{
    public Transform target;
    public float Smooth_Time = 0.25f;
    public Vector3 velocity = Vector3.zero;
    public Vector3 offset = new Vector3(0f, 0f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, Smooth_Time);
    }
}
