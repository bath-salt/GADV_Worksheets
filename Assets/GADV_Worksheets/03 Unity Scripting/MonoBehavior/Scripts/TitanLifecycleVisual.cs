using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TitanLifecycleVisual : MonoBehaviour
{
    public Color activationColor;
    private SpriteRenderer spriteRenderer;
    private float moveSpeed = 2f;
    private float moveLimit = 3f;
    private Vector3 startPos;
    private int direction = 1;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = activationColor;

        Debug.Log("Awake: Titan-01 is configured");
    }

    void Start()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.0f);

        Debug.Log("Start: Titan-01 scaled for action.");
    }

    void Update()
    {
        transform.position += new Vector3(direction * moveSpeed * Time.deltaTime, 0, 0);
        if(Mathf.Abs(transform.position.x - startPos.x) >= moveLimit)
        {
            direction *= -1;
        }

        Debug.Log("Update: Titan-01 patrolling...");
    }
}


