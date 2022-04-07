using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo7
{
    public interface IEatable
    {
        public void EatMe(GameObject eater);
    }

    public interface IModifierScore
    {
        public void InitializeScoreManager(IScoreManager scoreManager);
    }

    public interface IScoreManager
    {
        public void ModifyScore(int value);
    }

    public interface IEnnemy
    {
        public void Attack(GameObject gameObject);
    }
}
