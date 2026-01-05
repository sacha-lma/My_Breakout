using UnityEngine;
using TMPro;

public class BallBehaviors : MonoBehaviour
{
    private Rigidbody2D _rb;
    
    public float minY = -5.5f;
    public float maxSpeed = 15f;
    public float speed = 10f;

    public GameObject Paddle;
    
    private int _score;
    public TextMeshProUGUI scoreText;

    private int _lives = 5;
    public GameObject[] lifeIcons;
    
    public GameObject gameOverPanel;
    public GameObject youWinPanel;
    public int bricksCount;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = Vector2.down * speed;
    }

    private void Update()
    {
        if (transform.position.y < minY)
        {
            if (_lives <= 0)
            {
                GameOver();
                return;
            }
            transform.position = Vector3.zero;
            transform.position = Vector3.forward;
            _rb.linearVelocity = Vector2.down * speed;
            Paddle.transform.position = Vector3.zero + Vector3.forward + Vector3.down * 4f;
            _lives--;
            if (_lives >= 0 && _lives < lifeIcons.Length)
            {
                lifeIcons[_lives].SetActive(false);
            }
        }

        if (_rb.linearVelocity.magnitude > maxSpeed)
        {
            _rb.linearVelocity = _rb.linearVelocity.normalized * maxSpeed;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        switch (collision.gameObject.tag)
        {
            case "Brick":
                Destroy(collision.gameObject);
                _score += 100;
                scoreText.text = _score.ToString("00000");
                bricksCount--;
                break;
            case "Breakable":
                Destroy(collision.gameObject);
                _score += 250;
                scoreText.text = _score.ToString("00000");
                bricksCount--;
                break;
        }

        if (bricksCount <= 0)
        {
            YouWin();
        }
    }
    
    private void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        Destroy(gameObject);
    }

    private void YouWin()
    {
        youWinPanel.SetActive(true);
        Time.timeScale = 0f;
        Destroy(gameObject);
    }
}
