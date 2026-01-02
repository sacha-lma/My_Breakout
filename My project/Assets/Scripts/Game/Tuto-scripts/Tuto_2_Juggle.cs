using System;
using UnityEngine;

public class Tuto_2_Juggle : MonoBehaviour
{
    private int _toWin;
    public GameObject youWinPanel;

    private void Update()
    {
        if (_toWin >= 6)
        {
            YouWin();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Paddle")
        {
            _toWin++;
        }
    }
    
    private void YouWin()
    {
        youWinPanel.SetActive(true);
        Time.timeScale = 0f;
        Destroy(gameObject);
    }
}
