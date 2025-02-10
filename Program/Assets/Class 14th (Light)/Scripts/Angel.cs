using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angel : Ghost
{
    public override void Effect()
    {
        Debug.Log("Resurrection");
    }
    
    void Start()
    {
        health = 75;
        speed = 10;
        Effect();
    }
}
