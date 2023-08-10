using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab; // Prefab to spawn
    public Transform spawnPoint; // Point to spawn the prefab
    public float spawnDelay = 1f; // Delay between spawns
    public float moveSpeed = 5f; // Speed at which the prefab moves
    public float despawnTime = 10f; // Time after which the prefab despawns

    private float spawnTimer; // Timer to track spawn delay
    private GameObject spawnedPrefab; // Reference to the spawned prefab
    private float spawnTimestamp; // Time when the prefab was spawned

    private void Start()
    {
        spawnTimer = 0f;
    }

    private void Update()
    {
        // Spawn the prefab with the specified delay
        if (spawnTimer <= 0f)
        {
            spawnedPrefab = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
            spawnTimer = spawnDelay;
            spawnTimestamp = Time.time;
        }

        // Move the spawned prefab in the z-direction
        if (spawnedPrefab != null)
        {
            spawnedPrefab.transform.position += new Vector3(0f, 0f, moveSpeed * Time.deltaTime);
        }

        // Despawn the prefab after the specified time
        if (spawnedPrefab != null && Time.time - spawnTimestamp >= despawnTime)
        {
            Destroy(spawnedPrefab);
        }

        spawnTimer -= Time.deltaTime;
    }
}
