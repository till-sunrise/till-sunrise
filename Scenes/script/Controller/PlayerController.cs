using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Player player;
    float StaticTime = 2.0f;
    float DeltaTime;
    // Start is called before the first frame update

    void Start()
    {
        DeltaTime = StaticTime;
        player = new Player();
    }

    // Update is called once per frame
    void Update()
    {
        //if the player stay static
        if (IsEqual(Input.GetAxis("Vertical"), 0.0f))
        {
            DeltaTime -= Time.deltaTime;
        }
        else
        {
            DeltaTime = StaticTime;
        }
        if (IsEqual(DeltaTime, 0.0f))
        {
            player.Heal(5);
            DeltaTime = StaticTime;
        }
    }

    bool IsEqual(float a, float b)
    {
        if (a >= b - Mathf.Epsilon && a <= b + Mathf.Epsilon)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}
