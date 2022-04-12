using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
