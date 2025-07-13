using UnityEngine;
using System.Collections;

public class Coroutines : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Infinite());
    }

    IEnumerator Infinite()
    {
        while (true)
        {
            Debug.Log("Now I yield");
            yield return null;
        }
    }
}