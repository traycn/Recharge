using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collide)
    {
        SpawnManager sm = new SpawnManager();
        sm.hitIconsCount += 1;
    }
}
