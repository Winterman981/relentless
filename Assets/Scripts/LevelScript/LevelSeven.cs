using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSeven : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius = 1f;

    public GameObject[] enemy;

    private void Start()
    {
        StartCoroutine(LevelSevenSpawn());
    }

    void SpawnRocket()
    {
        Vector2 spawnPos = GameObject.Find("EnemySpawn").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy[0], spawnPos, Quaternion.identity);
    }

    void SpawnRifle()
    {
        Vector2 spawnPos = GameObject.Find("EnemySpawn").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy[1], spawnPos, Quaternion.identity);
    }

    IEnumerator LevelSevenSpawn()
    {
        yield return new WaitForSeconds(5);
        SpawnRocket();
        yield return new WaitForSeconds(3);
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(5);
        StartCoroutine(LevelSevenSpawn());
    }
}
