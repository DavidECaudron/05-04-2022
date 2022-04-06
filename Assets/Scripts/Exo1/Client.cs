using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MecQuiADesChouxEtDuPognon
{

    public Farmer farmer;

    void Awake()
    {
        SetUp(0, 100);
    }

    public void AcheteChoux()
    {
        if(ALeBudget(2) && farmer.AUnChou())
        {
            ModifieChoux(1);
            ModifieBudget(-2);
            farmer.VendsChoux();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AcheteChoux();
        }
    }
}
