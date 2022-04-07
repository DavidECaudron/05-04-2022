using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo7
{
    public class ScoreManagerInDebug : MonoBehaviour, IScoreManager
    {
        private int score = 0;
        public void ModifyScore(int value)
        {
            score += value;
            Debug.Log("Mon score est " + score);
        }
    }
}
