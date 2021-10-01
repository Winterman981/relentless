using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
    public Slider slider;
    public Color low;
    public Color high;
    public Vector3 offset;

    public RectTransform hpRect;

    
    public void SetHealth(float health, float maxHealth)
    {
        slider.gameObject.SetActive(health < maxHealth);
        slider.value = health;
        slider.maxValue = maxHealth;

        slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(low, high, slider.normalizedValue);
    }

    void Update()
    {
        //slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.parent.position + offset);

        hpRect.anchorMin = new Vector2(screenPosition.x / Screen.width, screenPosition.y / Screen.height);
        hpRect.anchorMax = new Vector2(screenPosition.x / Screen.width, screenPosition.y / Screen.height);
    }
}
