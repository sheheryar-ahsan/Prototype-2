using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBlockCollisions : MonoBehaviour
{
    private float timeSpan = 0.5f;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("Collided!");
        Time.timeScale += timeSpan; // Making the Game more fast on collion( By giving more lifes )

        if(Time.timeScale == 3)
        {
            Time.timeScale = 0;  // Making the game stop
            Debug.Log("Game Over");
        }
    }
}
