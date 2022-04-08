using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo8
{
    public class Salameche : Pokemon
    {
        int countAttack = 0;
        public override void OnSpawn()
        {
            base.OnSpawn();
            Invoke(nameof(Shoot), 0.1f);
        }

        void Shoot()
        {
            countAttack++;
            MissileSpawner.instance.Spawn(new SpawnInformationMissile(transform.position, Vector3.down, Color.red, 0.4f, 5));
            if (countAttack < 10)
                Invoke(nameof(Shoot), 0.1f);
        }

        public override void Attack(GameObject target)
        {
            MissileSpawner.instance.Spawn(new SpawnInformationMissile(transform.position, target.transform.position - transform.position, Color.red, 0.4f, 1));
        }

        public override bool TryCatch()
        {
            return false;
        }
    }
}
