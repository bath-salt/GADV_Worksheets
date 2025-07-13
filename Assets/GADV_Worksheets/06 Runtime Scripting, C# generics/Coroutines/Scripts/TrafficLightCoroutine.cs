using UnityEngine;
using System.Collections;

public class TrafficLightCoroutine : MonoBehaviour
{
    public GameObject greenLight;
    public GameObject amberLight;
    public GameObject redLight;

    void Start()
    {
        StartCoroutine(TrafficLoop());
    }

    IEnumerator TrafficLoop()
    {
        while (true)
        {
            // Green
            greenLight.SetActive(true);
            amberLight.SetActive(false);
            redLight.SetActive(false);
            yield return new WaitForSeconds(2f);

            // Amber
            greenLight.SetActive(false);
            amberLight.SetActive(true);
            redLight.SetActive(false);
            yield return new WaitForSeconds(2f);

            // Red
            greenLight.SetActive(false);
            amberLight.SetActive(false);
            redLight.SetActive(true);
            yield return new WaitForSeconds(2f);
        }
    }
}
