using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyFighting : MonoBehaviour
{
    public float attackRange;

    public Transform firePoint;
    public RifleBullet bulletPrefab;

    public float FireRate;
    float nextShot = 0;

    [SerializeField] private LayerMask targetLayers;

    [SerializeField] private int soundID;

    void Shoot() //Shooting Script
    {
        RifleBullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.SetDirection(firePoint.up);

        if(soundID == 1)
        {
            FindObjectOfType<AudioManager>().Play("Rifle");
        }
        if (soundID == 2)
        {
            FindObjectOfType<AudioManager>().Play("SMG");
        }
        if (soundID == 3)
        {
            FindObjectOfType<AudioManager>().Play("Sniper");
        }
        if (soundID == 4)
        {
            FindObjectOfType<AudioManager>().Play("MG");
        }
    }

    void Update()
    {
        var collider = Physics2D.OverlapCircle(transform.position, attackRange, targetLayers);
        if(collider != null)
        {
            this.GetComponent<WalkingAlly>().Stop();

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
            this.GetComponent<WalkingAlly>().Advance();
        }
    }
}
