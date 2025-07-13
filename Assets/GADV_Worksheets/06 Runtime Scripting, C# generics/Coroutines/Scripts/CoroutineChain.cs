using UnityEngine;
using System.Collections;

public class CoroutineChain : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Sequence());
    }

    IEnumerator Sequence()
    {
        yield return StartCoroutine(FlashRed());
        yield return StartCoroutine(MoveUp());
        Debug.Log("Sequence complete!");
    }

    IEnumerator FlashRed()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Flashing red...");
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
