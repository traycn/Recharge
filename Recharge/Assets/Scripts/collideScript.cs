using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideScript : MonoBehaviour
{
    public float hitIconsCount { get; set; }

    private void Start()
    {

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        hitIconsCount += 1;
        Destroy(gameObject);
    }


}
