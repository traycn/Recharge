using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideScript : MonoBehaviour
{

    private void Start()
    {

    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.name != "Player")
            return;

        Player player = collision.collider.GetComponent<Player>();

        if(player == null)
        {
            Debug.LogError("Something is wrong!");
        }

        player.AddScore();
        Destroy(gameObject);
    }


}
