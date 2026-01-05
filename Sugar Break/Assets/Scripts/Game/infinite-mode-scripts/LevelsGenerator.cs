using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class LevelsGenerator : MonoBehaviour
{
    public Vector2Int gridSize;
    public Vector2 offset;
    public GameObject[] brickPrefab;

    private void Awake()
    {
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                int index = UnityEngine.Random.Range(0, brickPrefab.Length);
                GameObject NewBrick = Instantiate(brickPrefab[index], transform);
                NewBrick.transform.position = transform.position + new Vector3(((gridSize.x - 1) * .5f - x) * offset.x, y * offset.y, 0);
            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
