using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleBullet : MonoBehaviour
{
	public GameObject hitEffect;
	public int rifleDamage = 7;
	public float speed = 120f;

	Vector2 _direction;
	Rigidbody2D rb;

	void Awake()
	{
		TryGetComponent(out rb);
	}

	void FixedUpdate()
	{
		rb.MovePosition(rb.position + _direction * speed * Time.fixedDeltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider) //Bullet Collision
	{
		GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
		Destroy(effect, 0.25f);
		Destroy(gameObject);

		UnitHealth enemy = collider.gameObject.GetComponent<UnitHealth>();
		if (enemy != null)
		{
			enemy.TakeDamage(rifleDamage);
		}
	}

	public void SetDirection(Vector2 direction)
	{
		_direction = direction;
	}
}
