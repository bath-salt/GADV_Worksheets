using UnityEngine;
using System.Collections;

public class MoveFlashCoroutines : MonoBehaviour
{
    public new Renderer renderer;
    Color originalColor;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;

        StartCoroutine(FlashRed());
        StartCoroutine(MoveUp());
    }

    IEnumerator FlashRed()
    {
        while (true) // Keep flashing as long as the object is moving
        {
            renderer.material.color = Color.red;
            yield return new WaitForSeconds(0.2f);
            renderer.material.color = originalColor;
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator MoveUp()
    {
        while (true)
        {
            transform.position += Vector3.up * 0.1f;
            yield return new WaitForSeconds(0.5f);
        }
    }
}