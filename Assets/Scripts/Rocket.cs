using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
	public GameObject hitEffect;
	public int grenadeDamage = 100;
	public float speed = 120f;
	public float SplashRange = 15f;

	Vector2 _direction;
	Rigidbody2D _rb;

	void Awake()
	{
		TryGetComponent(out _rb);
	}

	void FixedUpdate()
	{
		_rb.MovePosition(_rb.position + _direction * speed * Time.fixedDeltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider) //Bullet Collision
	{
		GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
		FindObjectOfType<AudioManager>().Play("Explosion");
		Destroy(effect, 0.25f);
		Destroy(gameObject);

		var hitColliders = Physics2D.OverlapCircleAll(transform.position, SplashRange);
		foreach (var hitCollider in hitColliders)
		{
			UnitHealth enemy = collider.gameObject.GetComponent<UnitHealth>();
			if (enemy)
			{
				var closestPoint = hitCollider.ClosestPoint(transform.position);
				var distance = Vector3.Distance(closestPoint, transform.position);

				var damagePercent = Mathf.InverseLerp(SplashRange, 0, distance);
				var totalDamage = Mathf.RoundToInt(damagePercent * grenadeDamage);
				enemy.TakeDamage(totalDamage);
			}
		}
	}

	public void SetDirection(Vector2 direction)
	{
		_direction = direction;
	}
}
