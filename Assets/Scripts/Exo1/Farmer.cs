using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo1
{
    public class Farmer : MecQuiADesChouxEtDuPognon
    {
        public Client client;

        private void Awake()
        {
            SetUp(2, 0);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                PlantACabbage();
            }
        }

        private void PlantACabbage()
        {
            if (HasBudget(1))
            {
                ModifyCabbage(+1);
                ModifyBudget(-1);
            }
        }

        public void SellCabbage()
        {
            //if (HasCabbage && client.HasBudget(2))
            //{
                ModifyCabbage(-1);
                ModifyBudget(+2);
            //}
        }
    }
}
