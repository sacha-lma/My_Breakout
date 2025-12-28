using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed;
    public float maxX;
    private float _horizontalInput;
    
    void Start()
    {
        
    }

    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        if (_horizontalInput > 0 && transform.position.x < maxX 
            ||
            _horizontalInput < 0 && transform.position.x > -maxX)
            transform.position += Vector3.right * (_horizontalInput * speed * Time.deltaTime);
    }
}
