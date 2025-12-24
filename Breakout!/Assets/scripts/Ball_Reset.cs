using UnityEngine;

public class Ball_Reset : MonoBehaviour
{
    public float minY = -5.5f;

    private Rigidbody2D RB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < minY)
            {
                transform.position = Vector3.zero;
                RB.linearVelocity = Vector2.zero;
            }
    }
}
