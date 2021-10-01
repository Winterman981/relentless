using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    public GameObject loseScreen;

    void Start()
    {
        loseScreen.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "EnemyUnit")
        {
            Lose();
        }
    }

    public void Lose()
    {
        loseScreen.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
