using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemeyGFX : MonoBehaviour
{
    public AIPath pathfind;

    void Update()
    {
        if (pathfind.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-3f, 3f,3f);
        }else if (pathfind.desiredVelocity.x <= -0.01f)
        {

            transform.localScale = new Vector3(3f, 3f,3f);
        }
    }
}
