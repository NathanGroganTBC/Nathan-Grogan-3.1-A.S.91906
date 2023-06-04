using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Image healthBarImage;
    public Sprite[] healthSprites;
    public int maxHealth = 10;

    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void DecreaseHealth()
    {
        currentHealth--;

        // Make sure the health doesn't go below 0
        if (currentHealth < 0)
            currentHealth = 0;

        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healthBarImage.sprite = healthSprites[currentHealth];
    }

    void Update()
    {
        if (currentHealth != 0)
        {
             DecreaseHealth();
        }
        else
        {
            currentHealth = 10;
        }
        Debug.Log(currentHealth);
    }
}