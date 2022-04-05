using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo1
{
    public class MecQuiADesChouxEtDuPognon : MonoBehaviour
    {
        [SerializeField] private int choux;
        [SerializeField] private int budget;

        public bool HasBudget(int budgetRequis)
        {
            /*
            if (budget >= budgetRequis)
            {
                return true;
            }
            
            return false;
            */

            // return (budget >= budgetRequis) ? true : false;

            return (budget >= budgetRequis);
        }

        public void SetUp (int choux, int budget)
        {
            this.choux = choux;
            this.budget = budget;
        }

        public bool HasCabbage()
        {
            return choux > 0;
        }

        public void ModifyCabbage(int modifier)
        {
            choux += modifier;
        }

        public void ModifyBudget(int modifier)
        {
            budget += modifier;
        }
    }
}

