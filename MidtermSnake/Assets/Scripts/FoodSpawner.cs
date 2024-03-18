using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject foodPrefab; // Reference to the food prefab
    public Vector2 spawnAreaSize = new Vector2(10f, 5f); // Size of the area where food can spawn

    public void RespawnFood()
    {
        // Calculate random spawn position within spawn area
        float spawnX = Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f);
        float spawnY = Random.Range(-spawnAreaSize.y / 2f, spawnAreaSize.y / 2f);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);

        // Instantiate food at spawn position
        Instantiate(foodPrefab, spawnPosition, Quaternion.identity);
    }
}