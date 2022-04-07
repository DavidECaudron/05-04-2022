using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace Exo7
{
    public class ProjectConnecter : MonoBehaviour
    {
        [SerializeField]
        GameObject score;
        void Awake()
        {
            List<IModifierScore> modifierScores = FindObjectsOfType<MonoBehaviour>().OfType<IModifierScore>().ToList();
            foreach (IModifierScore ms in modifierScores)
            {
                ms.InitializeScoreManager(score.GetComponent<IScoreManager>());
            }
        }
    }
}
