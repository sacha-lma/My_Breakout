using System;
using UnityEngine;

public class TwhoHitBrck : MonoBehaviour
{
    public Sprite damagedSprite;

    private void OnCollisionEnter2D(Collision2D other)
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == damagedSprite)
        {
            gameObject.tag = "Breakable";
        }
        else
        {
            spriteRenderer.sprite = damagedSprite;
        }
    }
}
