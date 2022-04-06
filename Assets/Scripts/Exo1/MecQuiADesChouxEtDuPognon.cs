using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecQuiADesChouxEtDuPognon : MonoBehaviour
{
    protected int choux;
    protected int budget;

    public bool ALeBudget(int budgetRequis)
    {
        return (budget >= budgetRequis);
    }

    public bool AUnChou()
    {
        return choux > 0;
    }

    public void SetUp(int choux, int budget)
    {
        this.choux = choux;
        this.budget = budget;
    }

    public void ModifieChoux(int modifieur)
    {
        choux += modifieur;
    }

    public void ModifieBudget(int modifieur)
    {
        budget += modifieur;
    }

}
