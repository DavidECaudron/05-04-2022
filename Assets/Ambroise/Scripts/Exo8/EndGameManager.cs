using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Exo8
{
    public class EndGameManager : MonoBehaviour, IEndGame
    {
        [SerializeField]
        GameObject parent;
        [SerializeField]
        Text salameche, carapuce, pikachu;
        [SerializeField]
        GameObject score;

        public void EndGame()
        {
            Dictionary<ETypePokemon, int> currentScore = score.GetComponent<IScore>().GetScore();
            parent.SetActive(true);
            salameche.text = "Salamèche : " + currentScore[ETypePokemon.Salameche];
            carapuce.text = "Carapuce : " + currentScore[ETypePokemon.Carapuce];
            pikachu.text = "Pikachu : " + currentScore[ETypePokemon.Pikachu];
        }
    }
}
