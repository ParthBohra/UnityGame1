using UnityEngine;

public class TextureMover : MonoBehaviour
{
    public Vector2 offsetSpeed = new Vector2(0.1f, 0.1f); // Speed at which the offset changes

    private Renderer rendererComponent; // Reference to the Renderer component
    private Vector2 currentOffset; // Current offset of the texture

    void Start()
    {
        // Get the Renderer component from the same GameObject
        rendererComponent = GetComponent<Renderer>();
    }

    void Update()
    {
        // Update the offset based on the speed and time
        currentOffset += offsetSpeed * Time.deltaTime;

        // Apply the updated offset to the texture
        rendererComponent.material.mainTextureOffset = currentOffset;
    }
}
