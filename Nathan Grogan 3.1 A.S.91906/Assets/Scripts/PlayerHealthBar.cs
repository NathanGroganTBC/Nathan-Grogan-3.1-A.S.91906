using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealthBar : MonoBehaviour
{
    public Image healthBarImage;
    public Sprite[] healthSprites;
    public int maxHealth = 9;

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
        {
            SceneManager.LoadScene(1);
            currentHealth = 0;
            
        }


        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healthBarImage.sprite = healthSprites[currentHealth];
    }

    void Update()
    {
        Debug.Log(currentHealth);
    }
}