using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Exo8
{
    public class Pokeball : Projectile
    {
        void OnTriggerEnter2D(Collider2D col)
        {
            Pokemon other = col.GetComponent<Pokemon>();
            if (other != null)
            {
                if (other.TryCatch())
                {
                    FindObjectsOfType<MonoBehaviour>().OfType<IScore>().First().Score(other.GetEType());
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }
}
