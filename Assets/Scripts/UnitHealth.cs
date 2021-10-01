using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth : MonoBehaviour
{
    public int Health;
    [SerializeField] private int Healthmax;
    public SpriteRenderer sprite;
    public HealthBarBehavior healthbar;

    [SerializeField] private GameObject blood;
    private void Start()
    {
        Healthmax = Health;
        healthbar.SetHealth(Health, Healthmax);
    }
    public void TakeDamage(int damage)
    {
        StartCoroutine(FlashRed());
        Health -= damage;
        healthbar.SetHealth(Health, Healthmax);

        if (Health <= 0)
        {
            Instantiate(blood, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public IEnumerator FlashRed()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        sprite.color = Color.white;
    }
}
