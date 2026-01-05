using UnityEngine;

public class FloatyButtons : MonoBehaviour
{
    public float speed;
    public float amplitude;
    
    private Vector3 _startPos;

    private void Start()
    {
        _startPos = transform.position;
    }

    private void Update()
    {
        transform.position = _startPos + new Vector3(0, Mathf.Sin(Time.time * speed) * amplitude, 0);
    }
}
