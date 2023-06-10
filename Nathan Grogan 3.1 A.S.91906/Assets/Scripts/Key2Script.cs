using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;


public class Key2Script : MonoBehaviour
{
    public Image keyImage;
    public Collider2D triggerCollider;
    public Tilemap key2Door;
    private TilemapRenderer tilemapRenderer;
    
    private bool isCollected;

    private void Start()
    {
        tilemapRenderer = key2Door.GetComponent<TilemapRenderer>();
    }
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
        tilemapRenderer.enabled = false;
        key2Door.GetComponent<Collider2D>().enabled = false;

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
