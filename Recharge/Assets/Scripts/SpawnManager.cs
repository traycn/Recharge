﻿using System;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
<<<<<<< HEAD
    public int hitIconsList { get; set; }
=======
    public float hitIconsCount { get; set; }
>>>>>>> 4a2bda0cfac2ff1db219bfcda1ef75021ed01080

    public GameObject[] iconObject;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    private bool startValue = true;

    ////public int? iconHits = null;
    
    public List<int> spawnPointArray = new List<int>();
<<<<<<< HEAD
    //public static String[] iconsHitList = null;
=======
>>>>>>> 4a2bda0cfac2ff1db219bfcda1ef75021ed01080
    ////List<int> iconObjectArray = new List<int>();

    // Start is called before the first frame up
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        if (spawnPointArray.Count != 8)
        {
            //START: Default show all spawn on initialization of the game
            if (startValue == true)
            {
                int spawnIconObject = 0;

                for (int i = 0; i < iconObject.Length; i++)
                {
                    spawnIconObject = i;

                    Instantiate(iconObject[spawnIconObject], spawnPoints[spawnIconObject].position, spawnPoints[spawnIconObject].rotation);

                    spawnPointArray.Add(i);
                }

                startValue = false;
            }
            //GAMEPLAY: check that all iconObjects have been hit
            else if (hitIconsList == 8)
            {
                int spawnIconObject = 0;

                for (int i = 0; i < iconObject.Length; i++)
                {
                    spawnIconObject = i;

                    Instantiate(iconObject[spawnIconObject], spawnPoints[spawnIconObject].position, spawnPoints[spawnIconObject].rotation);

                    spawnPointArray.Add(i);
                }
            }
        } else
        {
            //spawnPointArray == 8
            //DO NOTHING
        }





    }

    private void Update()
    {
        if(hitIconsCount == 8)
        {
            spawnPointArray = null;
        }
    }





    //if(playerHealth.currentHealth <= 0f)
    //{
    //          return;
    //}

    //int[] spawnPointArray = null;
    //int[] iconObjectArray = null;

    //int spawnPointIndex = 0;
    //int iconObjectIndex = 0;

    //if (iconHits == null)
    //{
    //    for (int i = 0; i < 4; i++)
    //    {

    ////spawnPointIndex = Random.Range(0, spawnPoints.Length);

    //   if (spawnPointArray.Contains(spawnPointIndex))
    //   {
    //       spawnPointIndex = Random.Range(0, spawnPoints.Length);
    //   }

    //   if (iconObjectArray.Contains(iconObjectIndex))
    //   {
    //       iconObjectIndex = Random.Range(0, iconObject.Length);
    //   }



    //spawnPointArray.Add(spawnPointIndex);
    //iconObjectArray.Add(iconObjectIndex);

    //    }
    //} else
    //{

    //}

    //int spawnPointIndex = Random.Range(0, spawnPoints.Length);
    //int iconObjectIndex = Random.Range(0, iconObject.Length);


    /// <summary>
    /// 
    /// GOOD OBJECTS vs BAD OBJECTS
    /// 
    /// Good Objects: 
    /// - food
    /// - game controller
    /// - music
    /// - plane
    /// 
    /// Bad Objects:
    /// - ambulance
    /// - sun
    /// - tax
    /// - work
    /// 
    /// 
    /// 
    /// </summary>
}
