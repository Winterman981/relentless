using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFour : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius = 1f;

    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LevelFourSpawn());
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

    IEnumerator LevelFourSpawn()
    {
        yield return new WaitForSeconds(2);
        SpawnRifle();
        yield return new WaitForSeconds(4);
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(4);
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(10);
        SpawnSniper();
        yield return new WaitForSeconds(8);
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(8);
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(4);
        SpawnRifle();
        yield return new WaitForSeconds(15);
        SpawnRocket();
        yield return new WaitForSeconds(12);
        SpawnAssault();
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(3);
        StartCoroutine(LevelFourSpawn());
    }
}
