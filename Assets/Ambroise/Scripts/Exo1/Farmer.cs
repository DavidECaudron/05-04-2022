using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo1
{
    public class Farmer : MecQuiADesChouxEtDuPognon
    {
        private void Awake()
        {
            SetUp(2, 0);
        }

        private void PlanteUnChoux()
        {
            if (ALeBudget(1))
            {
                ModifieBudget(-1);
                ModifieChoux(1);
            }
        }

        public void VendsChoux()
        {
            ModifieChoux(-1);
            ModifieBudget(2);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
                PlanteUnChoux();
        }
    }
}