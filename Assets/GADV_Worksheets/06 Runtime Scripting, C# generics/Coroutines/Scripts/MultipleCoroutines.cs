using UnityEngine;
using System.Collections;

public class MultipleCoroutines : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(FlashRed());
        StartCoroutine(MoveUp());
    }

    IEnumerator FlashRed()
    {
        while (true)
        {
            Debug.Log("Flashing!");
            yield return new WaitForSeconds(1f);
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