using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor 
{
    public float MaxBlood;
    public float Blood;
    public float Force;
    public float Speed;
    public bool Die;
    public void GetHurt(float damage)
    {
        if (Blood - damage <= 0)
        {
            Blood = 0;
            Die = true;
        }
        else
            Blood -= damage;
    }
    public void Heal(float value)
    {
        if ((Blood + value) >= MaxBlood)
            Blood = MaxBlood;
        else
            Blood += value;
    }
    public void Walk(Transform charactor,float input)
    {
        charactor.position += charactor.forward * Speed * Time.deltaTime * input;
    }
}
