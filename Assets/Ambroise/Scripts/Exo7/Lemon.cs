using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo7
{
    public class Lemon : MonoBehaviour, IEatable
    {
        public void EatMe(GameObject eater)
        {
            eater.transform.localScale *= 1.5f;
        }
    }
}
