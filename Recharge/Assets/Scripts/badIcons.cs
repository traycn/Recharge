﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badIcons : MonoBehaviour
{
    // Start is called before the first frame update
    //used on bad icons, when colliding with player, player restores position to vector2.zero/ Home.
    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.position = Vector2.zero;
    }
}
