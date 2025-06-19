using System;
using UnityEngine;

public class TreasureChest
{
    public virtual void unlock()
    {
        Debug.Log("You unlock the chest");
    }

    public virtual void unclock(bool hasToken) 
    {
        if (hasToken) 
        {
            Debug.Log("You unlocked the chest with a key and a special token. Bonus treasure inside!");
        }
        else
        {
            unlock();
        }
    }

    public void Shake()
    {
        Debug.Log("You hear something rattling inside the chest");
    }

}

public class AncientChest : TreasureChest
{
    public override void unlock()
    {
        Debug.Log("You unlock this chest with an ancient key");
    }

}


public class MagicChest : TreasureChest
{
    public override void unlock()
    {
        Debug.Log("You cast a magic spell to unlock the magic chest");
    }
}


