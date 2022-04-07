using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo7
{
    public class Apple : MonoBehaviour, IEatable, IModifierScore
    {
        IScoreManager scoreManager;
        public void EatMe(GameObject eater)
        {
            scoreManager.ModifyScore(5);
        }

        public void InitializeScoreManager(IScoreManager scoreManager)
        {
            this.scoreManager = scoreManager;
        }
    }
}
