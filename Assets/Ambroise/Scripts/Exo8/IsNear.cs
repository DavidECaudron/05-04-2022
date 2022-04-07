using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsNear : MonoBehaviour
{
    float timer = 0;
    bool isInContactOfPlayer;
    [SerializeField]
    Pokemon thisPokemon;

    void OnTriggerEnter2D(Collider2D col)
    {
        Ash other = col.GetComponent<Ash>();
        if (other != null)
        {
            isInContactOfPlayer = true;
            thisPokemon.Attack(col.gameObject);
        }
    }

    public float GetTimer()
    {
        return timer;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Ash other = col.GetComponent<Ash>();
        if (other != null)
        {
            isInContactOfPlayer = false;
            timer = 0;
        }
    }

    void Update()
    {
        if (isInContactOfPlayer)
            timer += Time.deltaTime;
    }
}
