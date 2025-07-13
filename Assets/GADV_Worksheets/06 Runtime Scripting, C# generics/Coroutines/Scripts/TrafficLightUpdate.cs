using UnityEngine;

public class TrafficLightUpdate : MonoBehaviour
{
    public GameObject greenLight;
    public GameObject amberLight;
    public GameObject redLight;

    private float timer = 0f;
    private int state = 0; // 0 = green, 1 = amber, 2 = red

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2f)
        {
            timer = 0f;
            state = (state + 1) % 3;

            greenLight.SetActive(state == 0);
            amberLight.SetActive(state == 1);
            redLight.SetActive(state == 2);
        }
    }
}
