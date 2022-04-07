using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo7
{
    public class Gobelin : MonoBehaviour, IEnnemy, IModifierScore
    {
        IScoreManager scoreManager;
        public void Attack(GameObject gameObject)
        {
            scoreManager.ModifyScore(-3);
        }

        public void InitializeScoreManager(IScoreManager scoreManager)
        {
            this.scoreManager = scoreManager;
        }
    }
}
