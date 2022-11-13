using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CibleSpawnController : MonoBehaviour
{
    [SerializeField] private Transform ciblesParent = default;
    [SerializeField] private BoxCollider cibleSpawnZone = default;
    [SerializeField] private GameObject ciblePrefab = default;
    private Bounds spawnBounds; //Extrémité
    [SerializeField] private float spawnSpeed = 1f;
    private bool hasStartedSpawning;

    private void Awake() {
        hasStartedSpawning = false;
        spawnBounds = cibleSpawnZone.bounds;
        StartSpawning();
    }

    public void StartSpawning() {
        if (!hasStartedSpawning) {
            StartCoroutine(DoSpawns());
            hasStartedSpawning = true;
        }
    }

    private IEnumerator DoSpawns() {
        while (true) {
            yield return new WaitForSeconds(2f / spawnSpeed);
            Instantiate(ciblePrefab, GetRandomSpawnPosition(), GetRandomRotation(), ciblesParent);
        }
    }

    private Vector3 GetRandomSpawnPosition() {
        return new Vector3(
            Random.Range(spawnBounds.min.x, spawnBounds.max.x),
            spawnBounds.min.y, 
            Random.Range(spawnBounds.min.z, spawnBounds.max.z));
    }

    private static Quaternion GetRandomRotation() {
        return Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
    }
}
