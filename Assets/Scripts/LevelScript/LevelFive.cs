using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFive : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius = 1f;

    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LevelFiveSpawn());
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

    void SpawnRocket()
    {
        Vector2 spawnPos = GameObject.Find("EnemySpawn").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy[3], spawnPos, Quaternion.identity);
    }

    IEnumerator LevelFiveSpawn()
    {
        yield return new WaitForSeconds(5);
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(4);
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(7);
        SpawnRifle();
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(8);
        SpawnSniper();
        yield return new WaitForSeconds(5);
        SpawnRifle();
        SpawnAssault(); 
        yield return new WaitForSeconds(8);
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(14);
        SpawnRocket();
        yield return new WaitForSeconds(3);
        StartCoroutine(LevelFiveSpawn());
    }
}
