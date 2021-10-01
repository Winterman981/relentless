using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deployment : MonoBehaviour
{
	[SerializeField]
	private float spawnRadius;

	public GameObject rifleman;
	public GameObject assault;
	public GameObject sniper;
	public GameObject rocketeer;
	public GameObject mg;
	public GameObject creditScript;

	Vector2 spawnPos;

	private void Start()
	{
		creditScript = GameObject.Find("DeploymentCanvas");
	}

	public void DeployRifleman()
	{
		spawnPos = GameObject.Find("Spawnpoint").transform.position;
		spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

		Credits creditCount = creditScript.GetComponent<Credits>();

		if (creditCount.totalCredits >= 200)
		{
			Instantiate(rifleman, spawnPos, Quaternion.identity);
			FindObjectOfType<Credits>().Subtract(200);
		}
	}

	public void DeployAssault()
	{
		spawnPos = GameObject.Find("Spawnpoint").transform.position;
		spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

		Credits creditCount = creditScript.GetComponent<Credits>();

		if (creditCount.totalCredits >= 300)
		{
			Instantiate(assault, spawnPos, Quaternion.identity);
			FindObjectOfType<Credits>().Subtract(300);
		}
	}

	public void DeploySniper()
	{
		spawnPos = GameObject.Find("Spawnpoint").transform.position;
		spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

		Credits creditCount = creditScript.GetComponent<Credits>();

		if (creditCount.totalCredits >= 600)
		{
			Instantiate(sniper, spawnPos, Quaternion.identity);
			FindObjectOfType<Credits>().Subtract(600);
		}
	}

	public void DeployRocket()
	{
		spawnPos = GameObject.Find("Spawnpoint").transform.position;
		spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

		Credits creditCount = creditScript.GetComponent<Credits>();

		if (creditCount.totalCredits >= 1200)
		{
			Instantiate(rocketeer, spawnPos, Quaternion.identity);
			FindObjectOfType<Credits>().Subtract(1200);
		}
	}
	public void DeployMG()
	{
		spawnPos = GameObject.Find("Spawnpoint").transform.position;
		spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

		Credits creditCount = creditScript.GetComponent<Credits>();

		if (creditCount.totalCredits >= 500)
		{
			Instantiate(mg, spawnPos, Quaternion.identity);
			FindObjectOfType<Credits>().Subtract(500);
		}
	}
}
