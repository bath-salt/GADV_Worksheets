using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite newSprite;

    private SpriteRenderer spriterenderer;

    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        
        if (newSprite != null)
        {
            spriterenderer.sprite = newSprite;
        }
    }
}
