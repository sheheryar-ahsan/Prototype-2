using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlocks : MonoBehaviour
{
    private float topBound = 5;
    private float lowerBound = -5;

    // Update is called once per frame
    void Update()
    {
        // if an object goes past the players view in the game, reomve the object 
        if (transform.position.x > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < lowerBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
