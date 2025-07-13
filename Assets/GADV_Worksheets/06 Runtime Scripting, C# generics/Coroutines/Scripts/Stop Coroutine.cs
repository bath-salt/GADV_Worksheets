using UnityEngine;
using System.Collections;

public class StopCoroutine : MonoBehaviour
{
    Coroutine flashRoutine;

    void Start()
    {
        flashRoutine = StartCoroutine(Flash());
        StartCoroutine(StopAfterSeconds(5));
    }

    IEnumerator Flash()
    {
        while (true)
        {
            Debug.Log("Flashing...");
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator StopAfterSeconds(float time)
    {
        yield return new WaitForSeconds(time);

        StopCoroutine(flashRoutine);

        Debug.Log("Stopped flashing");
    }
}
