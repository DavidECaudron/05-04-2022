using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Exo7
{
    public class RobinHood : MonoBehaviour, IEnnemy
    {
        public void Attack(GameObject gameObject)
        {
            List<Apple> modifierScores = FindObjectsOfType<Apple>().ToList();
            if (modifierScores != null && modifierScores.Count > 0)
                Destroy(modifierScores[0].gameObject);
        }
    }
}
