using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed;
    float horizontalInput;
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * horizontalInput * speed * Time.deltaTime;
    }
}
