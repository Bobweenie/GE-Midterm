using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value as needed

    private Vector3 direction = Vector3.right; // Initial direction

    void Update()
    {
        // Get input for changing direction
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Change direction if new input is received
        if (horizontalInput != 0f || verticalInput != 0f)
        {
            direction = new Vector3(horizontalInput, verticalInput, 0f).normalized;
        }

        // Move in the current direction
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}