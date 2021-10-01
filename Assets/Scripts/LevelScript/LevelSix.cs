using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSix : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius = 1f;

    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LevelSixSpawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAssault()
    {
        Vector2 spawnPos = GameObject.Find("EnemySpawn").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy[0], spawnPos, Quaternion.identity);
    }

    void SpawnMG()
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

    IEnumerator LevelSixSpawn()
    {
        yield return new WaitForSeconds(3);
        SpawnAssault();
        yield return new WaitForSeconds(8);
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(8);
        SpawnAssault();
        SpawnMG();
        yield return new WaitForSeconds(7);
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(10);
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(2);
        SpawnSniper();
        yield return new WaitForSeconds(7);
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(8);
        SpawnRocket();
        SpawnRocket();
        yield return new WaitForSeconds(17);
        StartCoroutine(LevelSixSpawn());
    }
}
