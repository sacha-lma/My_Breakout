using UnityEngine;

public class tuto_1_Movement : MonoBehaviour
{
    public GameObject paddle;
    public GameObject victoryUI;
    public float maxX;

    private bool _left = false;
    private bool _right = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (paddle.transform.position.x >= maxX && !_right)
        {
            _right = true;
        }
        if (paddle.transform.position.x <= -maxX && !_left)
        {
            _left = true;
        }

        if (_left && _right)
        {
            victory();
        }
    }

    void victory()
    {
        victoryUI.SetActive(true);
    }
}
