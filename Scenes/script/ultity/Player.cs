using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Charactor
{
    public Player()
    {
        Blood = 0;
        MaxBlood = 1000;  //??
        Force = 10;
        Speed = 1;
        Die = false;
    }
    public void Walk(Transform charactor, float input)
    {
        charactor.position += charactor.forward * Speed * Time.deltaTime * input;
    }
}
