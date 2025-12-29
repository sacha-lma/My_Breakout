using UnityEngine;
using TMPro;

public class BallBehaviors : MonoBehaviour
{
    private Rigidbody2D _rb;
    
    public float minY = -5.5f;
    public float maxSpeed = 15f;

    private int _score = 0;
    public TextMeshProUGUI scoreText;

    private int _lives = 5;
    public GameObject[] lifeIcons;
    
    public GameObject gameOverPanel;
    public GameObject YouWinPanel;
    int bricksCount;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        bricksCount = GameObject.FindGameObjectsWithTag("Brick").Length;
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
            _rb.linearVelocity = Vector3.zero;
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
        if (collision.gameObject.tag != "Brick") return;
        Destroy(collision.gameObject);
        _score += 100;
        scoreText.text = _score.ToString("00000");
        bricksCount--;
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
        YouWinPanel.SetActive(true);
        Time.timeScale = 0f;
        Destroy(gameObject);
    }
}
