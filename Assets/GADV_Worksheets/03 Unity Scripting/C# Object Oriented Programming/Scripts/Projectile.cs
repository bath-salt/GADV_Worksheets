using System;
using UnityEngine;

public class Projectile
{
    private float speed;

    public Projectile(float speed) 
    {
        this.speed = speed;
    }

    public void Fire()
    {
        if (speed > 0)
        {
            Debug.Log($"Firing Projectile at {speed} speed.");
        }
        else
        {
            Debug.Log("Cannot fire: Speed too low");
        }
    }

    public void AutoFire()
    {
        if (speed == 0)
        {
            speed = 100f;
        }

}
    

