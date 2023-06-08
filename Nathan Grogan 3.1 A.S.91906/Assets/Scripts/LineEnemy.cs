using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineEnemy : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float moveSpeed = 5f;
    public int damageAmount = 10;

    private Transform target;
    private bool movingTowardsPointA = true;

    private PlayerHealthBar playerHealthBar;


    private void Start()
    {
        target = pointA;
        // Get a reference to the PlayerHealthBar script
        playerHealthBar = FindObjectOfType<PlayerHealthBar>();
    }

    private void Update()
    {
        // Move towards the target
        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

        // Check if the enemy reached the target point
        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            // Change the target point
            if (movingTowardsPointA)
            {
                target = pointB;
            }
            else
            {
                target = pointA;
            }

            // Flip the enemy sprite to face the new direction
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale = newScale;

            // Change the direction flag
            movingTowardsPointA = !movingTowardsPointA;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Damage the player
            playerHealthBar.DecreaseHealth();
        }
    }
}
