using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo8
{
    public class Pokemon : MonoBehaviour, ISpawned, ICatchable, IAttacker
    {
        [SerializeField]
        private ETypePokemon typePokemon;

        public ETypePokemon GetEType()
        {
            return typePokemon;
        }
        public virtual void Attack(GameObject target)
        {
            Debug.Log("attack");
        }

        public virtual void OnSpawn()
        {

        }

        public virtual bool TryCatch()
        {
            return true;
        }
    }
}
