using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelThree : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius = 1f;

    public GameObject[] enemy;
    // Start is called before the first frame update

    Vector2 spawnPos;

    void Start()
    {
        spawnPos= GameObject.Find("EnemySpawn").transform.position;
        StartCoroutine(LevelThreeSpawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRifle()
    {
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy[0], spawnPos, Quaternion.identity);
    }

    void SpawnAssault()
    {
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy[1], spawnPos, Quaternion.identity);
    }

    void SpawnSniper()
    {
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy[2], spawnPos, Quaternion.identity);
    }

    IEnumerator LevelThreeSpawn()
    {
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(6);
        SpawnRifle();
        SpawnAssault();
        yield return new WaitForSeconds(8);
        SpawnRifle();
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(10);
        SpawnAssault();
        SpawnAssault();
        yield return new WaitForSeconds(8);
        SpawnAssault();
        yield return new WaitForSeconds(7);
        SpawnSniper();
        yield return new WaitForSeconds(4);
        SpawnRifle();
        SpawnRifle();
        yield return new WaitForSeconds(6);
        StartCoroutine(LevelThreeSpawn());
    }
}
