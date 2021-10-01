using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOne : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius = 1f;

    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LevelOneSpawn());
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

    IEnumerator LevelOneSpawn()
    {
        yield return new WaitForSeconds(5);
        SpawnRifle();
        yield return new WaitForSeconds(4);
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(6);
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(4);
        SpawnAssault();
        yield return new WaitForSeconds(10);
        SpawnRifle();
        SpawnAssault();
        SpawnRifle();
        yield return new WaitForSeconds(9);
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(1);
        StartCoroutine(LevelOneSpawn());
    }
}
