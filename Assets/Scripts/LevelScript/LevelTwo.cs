using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTwo : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius = 1f;

    [SerializeField] GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LevelTwoSpawn());
    }

    // Update is called once per frame
    void Update()
    {

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

    void SpawnSniper()
    {
        Vector2 spawnPos = GameObject.Find("EnemySpawn").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy[2], spawnPos, Quaternion.identity);
    }

    IEnumerator LevelTwoSpawn()
    {
        SpawnRifle();
        yield return new WaitForSeconds(2);
        SpawnRifle();
        yield return new WaitForSeconds(2);
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(6);
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(10);
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(5);
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(8);
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(7);
        SpawnRifle();
        SpawnAssault();
        yield return new WaitForSeconds(8);
        StartCoroutine(LevelTwoSpawn());
    }
}
