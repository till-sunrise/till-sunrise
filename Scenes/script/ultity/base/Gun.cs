using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class gun
{
    protected float Force;
    protected float MaxBulletNumber;
    protected float BulletNumber;
    protected void Fire()
    {
        if (BulletNumber > 0)
            BulletNumber--;
    }
}
