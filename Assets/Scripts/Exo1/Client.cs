using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo1
{
    public class Client : MecQuiADesChouxEtDuPognon
    {
        public Farmer farmer;

        private void Awake()
        {
            SetUp(0, 100);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                BuyCabbage();
            }
        }

        public void BuyCabbage()
        {
            if (HasBudget(2) /*&& farmer.HasCabbage*/)
            {
                ModifyCabbage(+1);
                ModifyBudget(-2);
                farmer.SellCabbage();
            }
        }
    }
}

