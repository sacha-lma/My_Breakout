using UnityEngine;

public class BallBehaviors : MonoBehaviour
{
    public float minY = -5.5f;
    public float maxSpeed = 15f;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y < minY)
        {
            transform.position = Vector3.zero;
            _rb.linearVelocity = Vector3.zero;
        }

        if (_rb.linearVelocity.magnitude > maxSpeed)
        {
            _rb.linearVelocity = _rb.linearVelocity.normalized * maxSpeed;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            Destroy(collision.gameObject);
        }
    }
}
