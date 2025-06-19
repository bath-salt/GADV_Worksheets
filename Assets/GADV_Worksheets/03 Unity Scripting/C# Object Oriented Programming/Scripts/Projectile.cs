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
            AutoFire();
        }
    }

    public void AutoFire()
    {
        if (speed == 0)
        {
            speed = 100f;
            Debug.Log("The Speed was 0. AutoFire set speed to 100 and launched!");
        }
    }
}

public class Player
{
    private int health;

    public Player(int health)
    {
        this.health = health;
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    public int GetHealth()
    {
        return health;
    }
}

public class ScoreTracker
{
    private int score;

    public int GetScore()
    {
        return score;
    }

    public void resetScore()
    {
        score = 0;
    }

}
    

