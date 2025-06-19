using System.Runtime.CompilerServices;
using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
{
    private Color asteroidColour;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        
        asteroidColour = spriteRenderer.color;

        if (asteroidColour == Color.white)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                spriteRenderer.color = Color.blue;
                asteroidColour = spriteRenderer.color;
            }
        }else if (asteroidColour == Color.blue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                spriteRenderer.color = Color.white;
                asteroidColour = spriteRenderer.color;
            }
        }
        


            
    }
}
