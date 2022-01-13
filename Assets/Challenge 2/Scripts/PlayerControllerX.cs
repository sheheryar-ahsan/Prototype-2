﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("SpawingDog", 0.5f, 0);
            Debug.Log("New Dog Spawned");
        }
    }
    void SpawingDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation); 
    }
}
