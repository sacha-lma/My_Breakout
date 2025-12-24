 using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;
    float horizontalInput;
    public float max_X = 3.1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if ((horizontalInput < 0 && transform.position.x > -max_X) ||
            (horizontalInput > 0 && transform.position.x < max_X))
        {
            transform.position += Vector3.right * horizontalInput * speed * Time.deltaTime;
        }
    }
}
