using System.Collections;
using UnityEngine;

public class MaterialFader : MonoBehaviour
{
    Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void OnMouseDown()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        for (float alpha = 1f; alpha >= 0; alpha -= 0.05f)
        {
            Color c = mat.color;
            c.a = alpha;
            mat.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
