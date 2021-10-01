using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeFightingEnemy : MonoBehaviour
{
    public float attackRange;
    //public Transform Target;

    //Vector2 Direction;

    public Transform firePoint;
    public Rocket bulletPrefab;

    public float FireRate;
    float nextShot = 0;

    [SerializeField] private LayerMask targetLayers;

    [SerializeField] private int soundID;

    //public LayerMask visionConeLayerMask;

    void Shoot() //Shooting Script
    {
        Rocket bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.SetDirection(firePoint.up);

        if (soundID == 5)
        {
            FindObjectOfType<AudioManager>().Play("Rocket");
        }
    }

    void Update()
    {
        var collider = Physics2D.OverlapCircle(transform.position, attackRange, targetLayers);
        if(collider != null)
        {
            this.GetComponent<WalkingEnemy>().Stop();

            Vector2  Direction = collider.transform.position - this.transform.position;
            Quaternion Rotation = Quaternion.FromToRotation(transform.up, Direction);

            transform.rotation = Rotation * transform.rotation;

            if (Time.time > nextShot)
            {
                nextShot = Time.time + 1 / FireRate;
                Shoot();
            }
        }

        else
        {
            this.GetComponent<WalkingEnemy>().Advance();
        }
    }
}
