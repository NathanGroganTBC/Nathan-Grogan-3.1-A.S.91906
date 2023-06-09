using UnityEngine;
using UnityEngine.UI;

public class Key1Script : MonoBehaviour
{
    public Image keyImage;
    public Collider2D triggerCollider;
    
    private bool isCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isCollected)
        {
            CollectKey();
        }
    }

    private void CollectKey()
    {
        // Hide the nested sprite
        SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = false;
        }

        // Set the key as collected
        isCollected = true;

        // Show the UI image
        if (keyImage != null)
        {
            keyImage.gameObject.SetActive(true);
        }
    }

    public bool IsKeyCollected()
    {
        return isCollected;
    }
}
