using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 20.0f;
    private float XRange = 10.0f;
    public GameObject projectilePrefab;

    void Update()
    {
        // To Restrict the player to leave left side of the screen area
        if (transform.position.x < -XRange)
        {
            transform.position = new Vector3(-XRange, transform.position.y, transform.position.z);
        }
        // To Restrict the player to leave right side of the screen area
        if (transform.position.x > XRange)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        // To Move the player on the horizontal axis
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
