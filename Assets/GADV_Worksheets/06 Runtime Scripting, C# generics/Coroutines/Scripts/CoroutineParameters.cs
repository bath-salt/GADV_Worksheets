using UnityEngine;
using System.Collections;

public class CoroutineParameters : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(FadeOut(5f));
    }

    IEnumerator FadeOut(float duration)
    {
        Material mat = GetComponent<Renderer>().material;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            float newAlpha = 1f - (elapsed / duration);
            Color c = mat.color;
            c.a = newAlpha;
            mat.color = c;

            elapsed += Time.deltaTime;
            yield return null;
        }

        // Ensure it's fully transparent at the end
        Color final = mat.color;
        final.a = 0f;
        mat.color = final;
    }
}
