using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo8
{
    public class ScoreManager : MonoBehaviour, IScore
    {
        private Dictionary<ETypePokemon, int> score;

        void Awake()
        {
            score = new Dictionary<ETypePokemon, int>();
            score.Add(ETypePokemon.Carapuce, 0);
            score.Add(ETypePokemon.Pikachu, 0);
            score.Add(ETypePokemon.Salameche, 0);
        }

        public void Score(ETypePokemon pokemon)
        {
            score[pokemon]++;
        }

        public Dictionary<ETypePokemon, int> GetScore()
        {
            return score;
        }
    }
}
