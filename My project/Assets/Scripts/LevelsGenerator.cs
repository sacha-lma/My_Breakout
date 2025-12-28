using System;
using UnityEngine;

public class LevelsGenerator : MonoBehaviour
{
    public Vector2Int gridSize;
    public Vector2 offset;
    public GameObject brickPrefab;
    public Gradient brickColorGradient;

    private void Awake()
    {
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                GameObject NewBrick = Instantiate(brickPrefab, transform);
                NewBrick.transform.position = transform.position + new Vector3(((gridSize.x - 1) * .5f - x) * offset.x, y * offset.y, 0);
                NewBrick.GetComponent<SpriteRenderer>().color = brickColorGradient.Evaluate((float)y / (gridSize.y - 1));
            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
