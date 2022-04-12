using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
