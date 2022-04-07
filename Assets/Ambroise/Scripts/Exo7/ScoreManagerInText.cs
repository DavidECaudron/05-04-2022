using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Exo7
{
    public class ScoreManagerInText : MonoBehaviour, IScoreManager
    {
        private int score = 0;
        [SerializeField]
        private Text text;
        public void ModifyScore(int value)
        {
            score += value;
            text.text = "Votre score est : " + score;
        }
    }
}
