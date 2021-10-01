using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEight : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius = 1f;

    public GameObject[] enemy;

    private void Start()
    {
        StartCoroutine(LevelEightSpawn());
    }

    void SpawnRifle()
    {
        Vector2 spawnPos = GameObject.Find("EnemySpawn").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy[0], spawnPos, Quaternion.identity);
    }

    void SpawnAssault()
    {
        Vector2 spawnPos = GameObject.Find("EnemySpawn").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy[1], spawnPos, Quaternion.identity);
    }

    IEnumerator LevelEightSpawn()
    {
        yield return new WaitForSeconds(7);
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(6);
        SpawnAssault();
        SpawnAssault();
        SpawnRifle();
        yield return new WaitForSeconds(7);
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(5);
        SpawnAssault();
        SpawnRifle();
        yield return new WaitForSeconds(8);
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        SpawnAssault();
        SpawnAssault();
        StartCoroutine(LevelEightSpawn());
    }
}
