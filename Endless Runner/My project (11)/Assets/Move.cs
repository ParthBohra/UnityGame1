using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed of movement

    void Update()
    {
        // Get input from W, A, S, D keys
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate new position based on input and speed
        Vector3 newPosition = transform.position + new Vector3(-horizontal, 0.0f, 0) * moveSpeed * Time.deltaTime;

        // Move the prefab to the new position
        transform.position = newPosition;
    }
}
